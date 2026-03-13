namespace Thedreamproperties.Context
{
    internal class SqlParameter
    {
        private string v;
        private string name;
        private DateTime now;

        public SqlParameter(string v, string name)
        {
            this.v = v;
            this.name = name;
        }

        public SqlParameter(string v, DateTime now)
        {
            this.v = v;
            this.now = now;
        }
    }
}