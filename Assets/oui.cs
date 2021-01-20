using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        
        Transform child = transform;
        Transform parent = GameObject.Find("Capsule").transform;
        Debug.Log(parent.position.x);
        Vector3 direction = new Vector3(
            child.position.x-parent.position.x , 
            child.position.y-parent.position.y ,
            child.position.z-parent.position.z );
        Quaternion m_MyQuaternion;
        m_MyQuaternion = new Quaternion();
        m_MyQuaternion.SetFromToRotation(Vector3.up, direction);
        child.position = Vector3.Lerp(child.position, transform.position, 1 * Time.deltaTime);
        child.rotation = m_MyQuaternion * child.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
