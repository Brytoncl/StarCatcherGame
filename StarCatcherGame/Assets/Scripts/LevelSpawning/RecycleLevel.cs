using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour 
{

	public List<SendToRecycler> recycleList;
	private Vector3 movePos;

	private int i = 0;

	void SendThisHandler (SendToRecycler _recycler)
	{
		recycleList.Add (_recycler);
		print (recycleList.Count);
	}

	// Use this for initialization
	void Start () 
	{
		recycleList = new List<SendToRecycler> ();
		SendToRecycler.SendThis += SendThisHandler;

	}
	void OnTriggerEnter () 
	{
		i = UnityEngine.Random.Range (0, recycleList.Count - 1); 
		movePos.x = Statics.nextPosition;
		recycleList[i].transform.position = movePos;
		if (recycleList.Count > 0);
		Statics.nextPosition += Statics.distance;
	}
	

}
