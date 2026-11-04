using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Adult john = new Adult("john", 28, 173);
        Baby lisa = new Baby("lisa", 3, 95);

        Debug.Log(john.age);
        lisa.Sleep();
    }
}

class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }
}

class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
}