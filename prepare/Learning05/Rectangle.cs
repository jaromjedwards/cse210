using System;

public class Rectangle : Shapes{

    protected float _width;
    protected float _height;

    public float GetWidth(){
        return _width;
    }

    public void SetWidth(float width){
        _width = width;
    }

    public float GetHeight(){
        return _height;
    }

    public void SetHeight(float height){
        _height = height;
    }

    public override float GetArea(){
        return _width * _height;
    }
}