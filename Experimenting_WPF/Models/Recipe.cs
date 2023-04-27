namespace Experimenting_WPF.Models
{
    public class Recipe
    {
        //variable for recipe name
        private string _recipeName;

        //variable for number of ingredients
        private int _numIngredients;

        //variable for array of objects
        private Ingredient[] _ingredients;

        //variable for number of instructions
        private int _numMethodSteps;

        //variable for arrray of objects
        private Method[] _steps;

        //variable for image ur;
        private string _recipeImageURL;

        //the amount that trakcs the current scaled amount
        private float _scaleUpAmount;

        //the amount that tracks all scaled up amounts by multiplying every time while the user has not chosen to scale down yet
        private float _scaleDownAmount;

        public Recipe(string recipeName, int numIngredients, Ingredient[] ingredient, int numMethodSteps, Method[] step, string recipeImageURL)
        {
            _scaleUpAmount = 1f;
            _scaleDownAmount = 1f;

            _recipeName = recipeName;
            _recipeImageURL = recipeImageURL;
            _numIngredients = numIngredients;
            _steps = step;
            _numMethodSteps = numMethodSteps;
            _recipeImageURL = recipeImageURL;

        }

        public string RecipeName
        {
            get { return _recipeName; }
            set { _recipeName = value; }
        }
        public int NumIngredients
        {
            get { return _numIngredients; }
            set { _numIngredients = value; }
        }
    }
}
