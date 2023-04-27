namespace Experimenting_WPF.Models
{
    //class of Ingredient to manage Ingredient variables
    public class Ingredient
    {
        //private variable declaration
        private string _ingredientName;

        //variable properties such as get set methods
        public string IngredientName { get { return _ingredientName; } set { _ingredientName = value; } }

        //private variable declaration
        private float _quantity;

        //variable properties such as get set methods
        public float Quantity { get { return _quantity; } set { _quantity = value; } }

        //private variable declaration
        private string _measurement;

        //variable properties such as get set methods
        public string Measurement { get { return _measurement; } set { _measurement = value; } }

        //parameterized constructor to initialize the variables to the values of the parameters
        public Ingredient(string ingredientName, float quantity, string measurement)
        {
            _ingredientName = ingredientName;
            _quantity = quantity;
            _measurement = measurement;
        }
    }
}
