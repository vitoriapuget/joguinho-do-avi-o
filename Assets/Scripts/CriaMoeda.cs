using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriaMoeda : MonoBehaviour
{
    public GameObject moeda;
    
    // Start is called before the first frame update
    void Start()
    {
      
        CriaCircunferencia();
        CriaCircunferencia1();
        CriaCircunferencia2();
    }
   
    void CriaParabola(){
        float y;

        for (float x = -10; x < 10; x+=0.9f)
        {
            
                // parábola
                y = (float)(-0.1*x*x+2*x+0);
            
                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
            
        }
    }
    void CriaCircunferencia(){
        float y,x;
        float raio = 2.5f;

        for (double teta = 0; teta <  Math.PI; teta+=0.3)
        {
            
                //circunferência
                x = (float)(raio*Math.Cos(teta));
                y = (float)(raio*Math.Sin(teta));

                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
        }
    }
    void CriaCircunferencia1()
    {
        float y, x;
        float raio = 4.5f;

        for (double teta = 0; teta < Math.PI; teta += 0.3)
        {

            //circunferência
            x = (float)(raio * Math.Cos(teta));
            y = (float)(raio * Math.Sin(teta));

            Instantiate(moeda, new Vector3(x, y, -2), Quaternion.identity);

        }
    }
    void CriaCircunferencia2()
    {
        float y, x;
        float raio = 3.5f;

        for (double teta = 0; teta < Math.PI; teta += 0.3)
        {

            //circunferência
            x = (float)(raio * Math.Cos(teta));
            y = (float)(raio * Math.Sin(teta));

            Instantiate(moeda, new Vector3(x, y, -2), Quaternion.identity);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
