using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Dog dog = new Dog("Bone", "Max", true, "dog");
        dog.Breed = "buldog";
        dog.AnimalColor = "white";
        dog.AnimalType = "dog";
        dog.Eat();
    }
    public class Animal
    {
        public string AnimalType;
        public string AnimalColor;
        public float AnimalWeight;
        public float AnimalHeight;
        public int AnimalAge;
        
        public Animal(bool IsMammal, string animalType)
        {
            AnimalType = animalType;
            Debug.Log(IsMammal);
        }

        public void Eat()
        {
            Debug.Log(AnimalType + " eats");
        }

        public void Poop()
        {
            Debug.Log(AnimalType + " poops");
        }

        public void TellTheParameters()
        {
            Debug.Log(AnimalType + " is " + AnimalColor + " is " + AnimalAge + " years old, is " + AnimalHeight + " tall and weight " + AnimalWeight + " kilogramms");
        }
    }

    public class Dog: Animal
    {
        public Dog(string FavoriteFood, string Name, bool IsKind, string animalType) : base(true, animalType)
        {
            Debug.Log(Name + " " + FavoriteFood + " " + " is kind: " + IsKind);
        }

        public string Breed;
        public bool KnowsCommands;

        public void Barking()
        {
            Debug.Log("woof woof");
        }
    }

    public class Cat : Animal
    {
        public Cat(): base(true, "cat")
        {

        }

        public bool IsFluffy;

        public void CatchMouses()
        {
            Debug.Log("catches mouses");
        }
    }
}
