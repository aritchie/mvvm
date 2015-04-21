using System;


namespace Acr {

    public class Command<T> : Command {

        public Command(Action<T> execute) : base(x => execute((T)x)) {
            if (execute == null)
                throw new ArgumentNullException("execute");
        }


        public Command(Action<T> execute, Func<T, bool> canExecute) : base(x => execute((T)x), x => canExecute((T)x)) {
            if (execute == null)
                throw new ArgumentNullException("execute");

            if (canExecute == null)
                throw new ArgumentNullException("canExecute");
        }
    }
}
