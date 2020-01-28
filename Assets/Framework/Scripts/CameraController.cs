using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject observable;
    public float cameraSpeed;
    public float followDampening;


     public float zoomMultiplier = 0.1f;
     public float targetOrtho;
     public float smoothSpeed = 2.0f;
     public float minOrtho = 1.0f;
     public float maxOrtho = 20.0f;

    Rigidbody2D observableRB;

    // Start is called before the first frame update
    void Start() 
    {
        observableRB = observable.GetComponent<Rigidbody2D>();
        targetOrtho = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (observable == null){ //Dont update anything if there is nothing to observe
            return;
        }

        Vector2 targetPosition = observableRB.velocity * cameraSpeed + new Vector2(observable.transform.position.x, observable.transform.position.y);
        transform.position = Vector2.Lerp(transform.position, targetPosition, followDampening*Time.deltaTime);
        

        if (observableRB.velocity.magnitude != 0.0f){
            targetOrtho = observableRB.velocity.magnitude * zoomMultiplier;
            targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
        }
        Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
    }
}
