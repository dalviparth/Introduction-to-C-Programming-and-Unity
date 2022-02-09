/*
EXERCISE 7: CALCULATIONS AND ROUNDING.
======================================

Temperature Conversions
In this exercise, you'll be converting temperatures from Fahrenheit to Celsius and back again.

To convert from Fahrenheit to Celsius:
--------------------------------------

  1. Begin by subtracting 32 from the Fahrenheit temperature.
  2. Divide the answer by 9.
  3. Finally, multiply by 5 to get the Celsius temperature.


To go convert Celsius to Fahrenheit:
------------------------------------

  1. Begin by multiplying the Celsius temperature by 9.
  2. Divide the answer by 5.
  3. Finally, add 32 to get the Fahrenheit temperature. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    void Start()
    {
        /*
         * Problem 1 – Temperature Calculations with Int
         * Create a new 2D Unity project named Exercise7. Add a scenes folder and save the current scene as scene0. Add a scripts folder and add a new C# script named ConvertTemperatures. 
         * 
         * Open the script, fill in the comment near the top of the script, and delete the Update method. Add the following code to the Start method:
         * 
         * Declare three int variables to store an original temperature in Fahrenheit, a calculated temperature in Celsius, and a calculated temperature in Fahrenheit(when you convert from Celsius back to Fahrenheit).
         * 
         * Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.
         * 
         * Assign 32 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.
         * 
         * Assign 212 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.
         * 
         * Attach the script to the Main Camera in the scene and run the game to see the output in the Console window.
         * 
         * You'll discover that the conversion from 0 to Celsius and back to Fahrenheit yields 5, not 0, for the final Fahrenheit temperature. That's one of the points of this exercise! Think about the data type you used and why you might get this result given that data type.
         */
        int fahrenheitOriginal1, celsiusCalculated1, fahrenheitBackValue1;

        //Test Cases #1:
        fahrenheitOriginal1 = 0;

        print("fahrenheitOriginal1: " + fahrenheitOriginal1);

        celsiusCalculated1 = ((fahrenheitOriginal1 - 32) / 9) * 5;
        print("celsiusCalculated1 = " + celsiusCalculated1);

        fahrenheitBackValue1 = (celsiusCalculated1 * 9) / 5 + 32;
        print("fahrenheitBackValue1 = " + fahrenheitBackValue1);

        //Test Cases #2:
        fahrenheitOriginal1 = 32;

        print("fahrenheitOriginal: " + fahrenheitOriginal1);

        celsiusCalculated1 = ((fahrenheitOriginal1 - 32) / 9) * 5;
        print("celsiusCalculated = " + celsiusCalculated1);

        fahrenheitBackValue1 = (celsiusCalculated1 * 9) / 5 + 32;
        print("fahrenheitBackValue = " + fahrenheitBackValue1);

        //Test Cases #3:
        fahrenheitOriginal1 = 212;

        print("fahrenheitOriginal: " + fahrenheitOriginal1);

        celsiusCalculated1 = ((fahrenheitOriginal1 - 32) / 9) * 5;
        print("celsiusCalculated = " + celsiusCalculated1);

        fahrenheitBackValue1 = (celsiusCalculated1 * 9) / 5 + 32;
        print("fahrenheitBackValue = " + fahrenheitBackValue1);

        /*
         * Problem 2 – Temperature Calculations with Float
         * 
         * Add the following code to the Start method after the code you already added:
         * 
         * Declare three float variables to store an original temperature in Fahrenheit, a calculated temperature in Celsius, and a calculated temperature in Fahrenheit (when you convert from Celsius back to Fahrenheit).
         * 
         * Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.
         * 
         * Now the conversion from 0 to Celsius and back to Fahrenheit is closer to 0, but it’s still not exactly 0. Remember, even though floating point numbers are approximations of the real numbers in the continuous domain, they give us more precision than whole numbers do. That's why we got a closer final Fahrenheit temperature when we used float variables instead of int variables.
         */

        float fahrenheitOriginal2, celsiusCalculated2, fahrenheitBackValue2;

        fahrenheitOriginal2 = 0F;  // F: reference for a Float number.

        print("fahrenheitOriginal2: " + fahrenheitOriginal2);

        celsiusCalculated2 = ((fahrenheitOriginal2 - 32) / 9) * 5;
        print("celsiusCalculated2 = " + celsiusCalculated2);

        fahrenheitBackValue2 = (celsiusCalculated2 * 9) / 5 + 32;
        print("fahrenheitBackValue2 = " + fahrenheitBackValue2);

        /*
         * Problem 3 – Temperature Calculations with Double
         * 
         * Add the following code to the Start method after the code you already added:
         * 
         * Declare three double variables to store an original temperature in Fahrenheit, a calculated temperature in Celsius, and a calculated temperature in Fahrenheit(when you convert from Celsius back to Fahrenheit).
         * 
         * Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.
         * 
         * Finally, the conversion from 0 to Celsius and back to Fahrenheit yields a 0 as you probably originally expected. Because the double data type uses more bytes than the float data type, we don’t get the rounding error we got when we used floats.
         * 
         * This exercise shows how data type really matters, especially when we do multiple calculations.
         */

        double fahrenheitOriginal3, celsiusCalculated3, fahrenheitBackValue3;

        fahrenheitOriginal3 = 0;

        print("fahrenheitOriginal3: " + fahrenheitOriginal3);

        celsiusCalculated3 = ((fahrenheitOriginal3 - 32) / 9) * 5;
        print("celsiusCalculated3 = " + celsiusCalculated3);

        fahrenheitBackValue3 = (celsiusCalculated3 * 9) / 5 + 32;
        print("fahrenheitBackValue3 = " + fahrenheitBackValue3);
    }
}
