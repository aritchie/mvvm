﻿using System;
using System.Windows.Input;


namespace Acr {

    public class Command : ICommand {
        private readonly Func<object, bool> canExecute;
        private readonly Action<object> execute;

        public event EventHandler CanExecuteChanged;


        public Command(Action<object> execute) {
            if (execute == null)
                throw new ArgumentNullException("execute");

            this.execute = execute;
        }


        public Command(Action execute) : this(x => execute()) {
            if (execute == null)
                throw new ArgumentNullException("execute");
        }


        public Command(Action<object> execute, Func<object, bool> canExecute) : this(execute) {
            if (canExecute == null)
                throw new ArgumentNullException("canExecute");

            this.canExecute = canExecute;
        }


        public Command(Action execute, Func<bool> canExecute) : this(x => execute(), x => canExecute()) {
            if (execute == null)
                throw new ArgumentNullException("execute");

            if (canExecute == null)
                throw new ArgumentNullException("canExecute");
        }


        public void Execute(object parameter) {
            this.execute(parameter);
        }


        public bool CanExecute(object parameter) {
            if (this.canExecute != null)
                return this.canExecute(parameter);
            return true;
        }


        public void ChangeCanExecute() {
			if (this.CanExecuteChanged != null)
				this.CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}
