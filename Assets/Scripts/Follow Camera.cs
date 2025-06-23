using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this things position (camera) should be the same as the car's position 

    void LateUpdate() // Late update when at very last of game logic updating
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
