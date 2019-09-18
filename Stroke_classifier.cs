using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
public class Stroke_classifier
{
    private List<int> classes = new List<int>();
    private int max_sample;
    private bool trained = false;
    private int min_Stroke_Point = 5;

    public List<double> xyratio = new List<double>();
    // public List<double>  = new List<double>();
    

    public Stroke_classifier(int classcount, int sample_count)
    {
        for (int i=0; i<classcount; i++)
        {
            classes.Add(i);
        }
        max_sample = sample_count;

    }
    public void addStroke(List<Vector2> inputStroke)
    {
        inputStroke = removeConsectiveRepeat(inputStroke);
        if(inputStroke.Count<min_Stroke_Point)
        {
            Debug.Log("Stroke_rejected");
            return;
        }
        xyratio.Add(xyratio_cal(inputStroke));

    }


    private List<Vector2> removeConsectiveRepeat(List<Vector2> inputStroke)
    {
        List<Vector2> returnThis = new List<Vector2>();
        foreach(Vector2 point in inputStroke)
        {
            if(returnThis.Count==0 || point != returnThis.Last())
            {
                returnThis.Add(point);
            }
        }
        return returnThis;
    }

    private double xyratio_cal(List<Vector2> inputStroke)
    {
        double x_min = double.PositiveInfinity;
        double x_max = double.NegativeInfinity;
        double y_min = double.PositiveInfinity;
        double y_max = double.NegativeInfinity;
        foreach(Vector2 point in inputStroke)
        {
            x_min = Math.Min(point.x, x_min);
            x_max = Math.Max(point.x, x_max);
            y_min = Math.Min(point.y, y_min);
            y_max = Math.Max(point.y, y_max);
        }
        return (x_max-x_min)/(y_max-y_min);
    }

    public Vector2 vectorDirection(Vector2 initialPoint, Vector2 finalPoint)
    {
        float angle = Vector2.Angle(initialPoint, finalPoint);
        Debug.Log(angle);
        return new Vector2(angle,angle);
    }

}
