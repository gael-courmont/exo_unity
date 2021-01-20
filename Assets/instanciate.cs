using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class instanciate : MonoBehaviour
{
    private Transform sphererHolder;
    [SerializeField] private int numberofSphere = 4;
    [SerializeField] private Vector3 rotationCenter = default;
    [SerializeField] private GameObject cubePrefab = default;
    [SerializeField] private float Radius= 9f;
    [SerializeField] private Vector3 position = default;

    private Transform parent;
    // Start is called before the first frame update
    void Start()
    {   
        sphererHolder = transform;
        StartCoroutine(Instancier());
        parent = GameObject.Find("Capsule").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Instancier()
    {
        while (true)
        {

            foreach(Transform child in sphererHolder) Destroy(child.gameObject);
            for (int i = 0; i < numberofSphere;i++)
            { 
                position = new Vector3(rotationCenter.x+ Radius * Mathf.Cos(2 * Mathf.PI * i / numberofSphere), rotationCenter.y + Radius * Mathf.Sin(2 * Mathf.PI * i / numberofSphere), rotationCenter.z);
                Vector3 direction = new Vector3(
                    position.x - transform.position.x, 
                    position.y - this.transform.position.y,
                    position.z - this.transform.position.z);
                GameObject truc= (GameObject) Instantiate(cubePrefab, position, Quaternion.identity,sphererHolder);
            }
            

            
            yield return new WaitForSeconds(5f);
        }
    }
}
