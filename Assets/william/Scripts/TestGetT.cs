using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass
{
    public int a = 1;
    public int b = 1;
    public float c = 1;
    public float d = 1;

    public T Get<T>(string valueName)
    {
        object value = this.GetType().GetField(valueName).GetValue(this);
        return (T)value;
    }

    public void Set<T>(string valueName,object obj, T inputValue)
    {
        object value = this.GetType().GetField(valueName).GetValue(this);
        //value = (T)inputValue;

        this.GetType().GetField(valueName).SetValue(obj, (T)inputValue);
    }
}

public class TestGetT : MonoBehaviour
{
    MyClass _myClass;
    // Start is called before the first frame update
    void Start()
    {
        MyClass _myClass = new MyClass();
        Debug.Log("_myClass.Get<int>(a) = "+ _myClass.Get<int>("a"));

        _myClass.Set<int>("a", _myClass, 998);

        Debug.Log("After Set, _myClass.Get<int>(a) = " + _myClass.Get<int>("a"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
