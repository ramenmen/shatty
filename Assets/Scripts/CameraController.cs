using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject followTarget;
	private Vector3 targetPos;
	public float moveSpeed;
    private static bool cameraExists;


    // Start is called before the first frame update
    void Start()
    {
        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(gameObject.transform);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
		targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y + 2, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
	}
}
