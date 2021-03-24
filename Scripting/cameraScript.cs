using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform followPlayer;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followPlayer.position.x, followPlayer.position.y, this.transform.position.z);
    }
}
