using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class knn 
{
    private List<double[]> trainingSetValues;
    private List<int> trainingSetClasses;

    private List<double[]> testSetValues;
    private List<int> testSetClasses;
    
    private double[][] distances;


    public void Train()
    {
        // trainingSetValues = new List<double[]>(){
        //     new double[] {0.735537, 0.25, 0.25, 0.5, 0},
        //     new double[] {0.703883, 0.204833, 0.295167, 0.5, 0},
        //     new double[] {0.4392523364485981,0.25,0.25,0.39758361765043326,0.8975836176504333},
        //     new double[] {0.5517241379310345,0.5,0.0,0.5,0.0},
        //     new double[] {0.711764705882353,0.06283295818900118,0.4371670418109988,0.5,0.0},
        //     new double[] {1.4222222222222223,0.9072264209222578,0.4072264209222578,0.8743340836219977,0.3743340836219977},
        //     new double[] {1.5864197530864197,0.9220208696226306,0.42202086962263063,0.9671881049234973,0.46718810492349727},
        //     new double[] {1.134453781512605,0.9114144672170952,0.4114144672170952,0.8246566008797258,0.6753433991202742},
        //     new double[] {1.506122448979592,0.9202814886502937,0.4202814886502937,0.8975836176504333,0.39758361765043326},
        //     new double[] {1.5728155339805825,1.0,0.5,0.9220208696226306,0.5779791303773694}
        // };
        // trainingSetClasses = new List<int>() {2,2,2,2,2,1,1,1,1,1};
        // // testSetValues = new List<double[]>(){
        // //     new double[] {0.6697247706422018,0.35241638234956674,0.14758361765043326,0.5,1.0},
        // //     new double[] {0.8247422680412371,0.35241638234956674,0.14758361765043326,1.0,0.5},
        // //     new double[] {1.5728155339805825,1.0,0.5,0.9220208696226306,0.5779791303773694},
        // //     new double[] {1.3423731019543235,1.0,0.5,0.9255976042367958,0.5744023957632042},
        // // };
        // // testSetClasses = new List<int>() {2,2,1,1};
        // double[][] distances = new double[trainingSetValues.Count][];
        // for (int i = 0; i < trainingSetValues.Count; i++)
        //     distances[i] = new double[2];
        
        
    }
    public void Classify(int neighborsNumber, double[] input)
    {
        // Parallel.For(0, trainingSetValues.Count, index =>
        //     {
        //         var dist = EuclideanDistance(input, this.trainingSetValues[index]);
        //         distances[index][0] = dist;
        //         distances[index][1] = index;
        //     }
        // );


        // // sort and select first K of them
        // var sortedDistances = distances.AsParallel().OrderBy(t => t[0]).Take(neighborsNumber);

        // int realClass = testSetClasses[test];

        // // print and check the result
        // foreach (var d in sortedDistances)
        // {
        //     int predictedClass = trainingSetClasses[(int) d[1]];
        //     if (realClass == predictedClass)
        //         correct++;
        //     testNumber++;
        //     Debug.Log("test" + test + " real class:"+realClass + " predicted class:" + predictedClass);
        //     // Console.WriteLine("[>>>] test {0}: real class: {1} predicted class: {2}", test, realClass, predictedClass);
        // }
    }
    private static double EuclideanDistance(double[] sampleOne, double[] sampleTwo)
    {
        double d = 0.0;

        for(int i = 0; i < sampleOne.Length; i++)
        {
            double temp = sampleOne[i] - sampleTwo[i];
            d += temp * temp;
        }
        return Math.Sqrt(d);
    }


    static void Main() 
    {
    }

}

