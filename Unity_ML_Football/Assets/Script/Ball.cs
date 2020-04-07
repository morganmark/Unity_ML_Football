
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static bool complete;
    private void OnTriggerEnter(Collider other) //soccer enter door,other = 碰到物件碰撞資訊
    {
        if(other.name == "進球感應區"){
            complete = true;
        }
    }
}
