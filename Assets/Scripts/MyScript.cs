using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.print number1-100 by using for loop
        //2.print even number 1*100 using for loop(2 4 6 8 10...100)
        //3.create a function that calculater area of a circle and print out the result.

        for(int i=0; i<=100; i++)
        {
            print(i);
        }
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                print(i);
            }

            float x = 1.0f;
            float r = circle(x);

        
            float circle(float x)
            {
                float result;
                x = 5.0f;
                result = 3.14f * x;
                print(result);
                return result;
            }

        }
}





  

    
    
     


}

