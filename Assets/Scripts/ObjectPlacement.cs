using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject theObject;


    void Update () {
        if ( Input.GetMouseButtonDown( 0 ) ) {
            Ray camRay = GetComponent<Camera>().ScreenPointToRay( Input.mousePosition ); //Create ray from screen click
            Vector3 rayDir = camRay.direction; //Get the ray direction
 
            GameObject gInstance = (GameObject) Instantiate( theObject ); //Instantiate the object
            gInstance.transform.position = transform.position; //Move object to camera position - object keeps its scale and rotation
 
            Vector3[] meshPoints = gInstance.GetComponent<MeshFilter>().sharedMesh.vertices; //Get verts of object mesh
            for ( int i = 0; i < meshPoints.Length; i++ ) {
                meshPoints[i] = gInstance.transform.TransformPoint( meshPoints[i] ); //Transform verts to world space (accounting for prefab rotation and scale)
            }
 
            gInstance.SetActive( false ); //Turn object off so it doesnt interfere with raycast
 
            float minDist = float.MaxValue;
 
            for ( int i = 0; i < meshPoints.Length; i++ ) {
                Ray pointRay = new Ray(  meshPoints[i], rayDir ); //New ray from each vert, in the direction of the screen ray
                //Debug.DrawRay( pointRay.origin, pointRay.direction * 5, Color.red, 4 );
                RaycastHit rayHit;
                if ( Physics.Raycast( pointRay, out rayHit ) ) {
                    if ( rayHit.distance < minDist ) {
                        minDist = rayHit.distance; //Find nearest ray hit
                    }
                }
            }
 
            gInstance.SetActive( true ); //Re-enable object
 
            gInstance.transform.position = gInstance.transform.position + rayDir * minDist; //Move object to surface
        }
    }

}
