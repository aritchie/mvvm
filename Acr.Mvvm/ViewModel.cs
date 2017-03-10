using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


namespace Acr
{

    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool FireInpcOnMainThread { get; set; } = true;
        public static Action<Action> MainThreadCall { get; set; }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.FireInpcOnMainThread && MainThreadCall != null)
            {
                MainThreadCall.Invoke(() =>
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName))
                );
            }
            else
            {
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> expression)
        {
            var member = expression.Body as MemberExpression;
            if (member == null)
                throw new ArgumentException("Member not found for expression");

            this.OnPropertyChanged(member.Member.Name);
        }


        protected virtual bool SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(property, value))
                return false;

            property = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
    }
}