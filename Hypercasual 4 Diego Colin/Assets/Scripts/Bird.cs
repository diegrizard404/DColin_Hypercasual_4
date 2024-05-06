using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	public Transform pivot;
	public float springRange;
	public float maxVel;

	public bool dropBird;

	Rigidbody2D rb;

	public float timer;
	//private float waitTime = 4f;

	bool canDrag = true;
	Vector3 dis;

	private void Awake()
    {
		dropBird = false;

        if (pivot.gameObject == null)
        {
			var pivotFind = pivot.gameObject;
			var ctbInPrefab = pivotFind.transform.Find("Pivote");
			pivot = ctbInPrefab;
		}
		
	}
    void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.bodyType = RigidbodyType2D.Kinematic;
	}

    private void Update()
    {
		/*
		if (dropBird == true)
		{
			timer += Time.deltaTime;

			if (timer > waitTime)
			{

				RespawnBird.instance.Spawnbird();
				Destroy(gameObject);
			}
		}
		*/
	}

    
	void OnMouseDrag()
	{
		if (!canDrag)
			return;

		var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		dis = pos - pivot.position;
		dis.z = 0;
		if (dis.magnitude > springRange)
		{
			dis = dis.normalized * springRange;
		}
		transform.position = dis + pivot.position;
	}

	void OnMouseUp()
	{
		if (!canDrag)
			return;
		canDrag = false;

		rb.bodyType = RigidbodyType2D.Dynamic;
		rb.velocity = -dis.normalized * maxVel * dis.magnitude / springRange;
		dropBird = true;
		Invoke("Reset", 4f);
	}

    private void Reset()
    {
		transform.position = pivot.position;
		rb.bodyType = RigidbodyType2D.Kinematic;
		rb.velocity = Vector2.zero;
		canDrag = true;
	}

    //Codigo de: https://youtu.be/jqvAKRUlJWY?si=4tAgzKNqDROuXt0c


}
