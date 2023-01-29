namespace Stranded
{
    public class Command
    {
        private List<string> arguments = new List<string>();
        private bool hasVariable;
        private string separator;
        private List<string> variables;
        private Action action;

        public List<string> Arguments { get => arguments; set => arguments = value; }
        public bool HasVariable { get => hasVariable; set => hasVariable = value; }
        public string Separator { get => separator; set => separator = value; }
        public List<string> Variables { get => variables; set => variables = value; }
        public Action Action { get => action; set => action = value; }

        public Command(List<string> arguments, bool hasVariable, Action action)
        {
            this.arguments = arguments;
            this.hasVariable = hasVariable;
            this.action = action;
            separator = "";
            variables = new List<string>();
        }

        public Command(List<string> arguments, bool hasVariable, Action action, string separator)
        {
            this.arguments = arguments;
            this.hasVariable = hasVariable;
            this.action = action;
            this.separator = separator;
            variables = new List<string>();
        }

        public void runVar(Action<string> action, string var)
        {
            action(var);
        }
        public void run()
        {
            action();
        }
    }
}