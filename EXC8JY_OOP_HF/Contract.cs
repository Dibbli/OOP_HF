namespace EXC8JY_OOP_HF
{
    public class Contract
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string deadline;
        public string Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        public virtual string Stuff
        {
            get { return Name + "," + Deadline; }
            set
            {
                string[] stuff = value.Split(',');
                name = stuff[0];
                deadline = stuff[1];
            }
        }

    }
}
