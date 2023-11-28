using System;

public class Circle : Shapes{

    protected float _radius;

    public float GetRadius(){
        return _radius;
    }

    public void SetRadius(float radius){
        _radius = radius;
    }

    public override float GetArea(){
        return (float)(_radius * _radius * Math.PI);
    }
}