using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseScript : MonoBehaviour
{
    public GameObject prefab;
    private bool spawned = false;
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && !spawned)
        {
            RaycastHit hit;
            Camera main = Camera.main;
            if (Physics.Raycast(new Ray(main.transform.position,main.transform.forward), out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.name.Equals("Button"))
                {
                    spawned = true;
                    var sc = Instantiate(prefab, hit.transform.parent.GetChild(0));
                    sc.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    sc.transform.localPosition = new Vector3(0, 0.5f, 0);
                }
            }
        }
    }
}
