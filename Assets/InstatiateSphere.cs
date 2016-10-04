using UnityEngine;
using System.Collections;

public class InstatiateSphere : MonoBehaviour
{
    private IEnumerator coroutine;

    public GameObject mySphere;
    GameObject mySphereClone;

    public GameObject myPlayer;

    private Transform playerPosition;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(InstantiateNow());
        playerPosition = myPlayer.GetComponent<Transform>() as Transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    IEnumerator InstantiateNow()
    {
        yield return new WaitForSeconds(5);
        mySphere = Instantiate(mySphere, GameObject.Find("FPSController").transform.position, Quaternion.identity) as GameObject;
    }
}
