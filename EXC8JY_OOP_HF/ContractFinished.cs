namespace EXC8JY_OOP_HF
{
    public class ContractFinished : Contract
    {

        string datefinished;
        public string DateFinished
        {
            get { return datefinished; }
            set { datefinished = value; }
        }
        string contractor;
        public string Contractor
        {
            get { return contractor; }
            set { contractor = value; }
        }        
        public override string Stuff
        {
            get { return base.Stuff + "," + DateFinished + "," + Contractor; }
            set
            {
                string[] stuff = value.Split(',');
                Name = stuff[0];
                Deadline = stuff[1];
                DateFinished = stuff[2];
                Contractor = stuff[3];
            }
        }
    }

}
