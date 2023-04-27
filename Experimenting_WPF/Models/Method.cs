namespace Experimenting_WPF.Models
{
    //class of Method to manage instructions variables
    public class Method
    {
        //private variable declaration
        private string _description;

        //variable properties such as get set methods
        public string Description { get { return _description; } set { _description = value; } }

        //parameterized constructor to initialize the variables to the values of the parameters
        public Method(string description)
        {
            _description = description;
        }
    }
}
