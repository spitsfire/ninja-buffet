# Ninja Buffet

Taking what we've learned from the **Human** and **Wizard, Ninja, Samurai** assignments, let's explore how different classes can interact with one another using private properties, public getters, and class methods.

For the everday ninja on a lunch break there is Ninja Buffet! It's All-You-Can-Eat, serving the hardworking ninjas of this world based on the six taste senses and calorie intake. Please note, we will be revisiting your work here in a later assignment.

## Tasks:

Create a *Food* class.

```
class Food
    {
        public string Name;
        public int Calories;
        public string Taste; // taste category will be one of the following: sweet, sour, spicy, salty, savory, or bitter

        // add a constructor that takes in all three parameters: Name, Calories, Taste
    }
```

Create a *Buffet* class, which will house the Food objects initialized.

```
class Buffet
    {
        public List<Food> Menu;

        // add a constructor and set Menu to a list of Food objects you instantiate manually

        // build out the Serve method that randomly selects a Food object from the Menu list and returns the Food object
        public Food Server()
        {
        }
    }
```

Create a *Ninja* class.

```
class Ninja
    {
        private int calorieIntake;
        public List<Food> foodHistory;

        // add a constructor that sets calorIntake to 0 and creates a new, empty list of Food objects to foodHistory

        // add a public "getter" property called "isFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories

        // build out the Eat method that: adds calorie value to ninja's total calorieIntake, adds the randomly selected Food object to ninja's foodHistory list, consoles food's name and taste, and consoles a warning when ninja is full and cannot eat anymore
        public void Eat(Food item)
        {
        }
    }
```
