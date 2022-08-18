using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvement : MonoBehaviour
{
[SerializeField]
Transform characterToFollow;

// Start is called before the first frame update
void Start()
{
}

// Update is called once per frame
void Update()
{
float newX = 0;
float newY = 0;
newX = characterToFollow.position.x;
newY = characterToFollow.position.y;

transform.position = new Vector3(newX, newY, transform.position.z);
}
}

