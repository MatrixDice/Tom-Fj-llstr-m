using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // string t;

    // string text = "Hello World!";

    // Change value from unity (Unity prio 1) with SerializeField
    // [SerializeField] string myName = "Tom";

    [SerializeField] int myPower = 9001;

    [SerializeField] Apple apple;

    // Start is called before the first frame update
    void Start()
    {
        // t = "text";

        // print(text);
        // print("Hello World!");
        // Debug.Log(text); // Unity debug only

        if (myPower > 9000){
            print("IT IS OVER 9000!");
        }
        else if(myPower == 1337){
            print("Elite");
        }
        else{
            print("Kinda weak...");
        }

        // Call function to count double of
        print(DoubleOf(24));

        // Call function in Apple.cs
        // print(apple.brand);

    }

    // Custom function
    void SayHello()
    {
        print("Hello!");
    }

    // Another function (with an integer return type and an integer parameter called number)
    int DoubleOf(int number){
        return number * 2;
    }

    // Update is called once per frame
    void Update()
    {
        // print(text);
    }
}
