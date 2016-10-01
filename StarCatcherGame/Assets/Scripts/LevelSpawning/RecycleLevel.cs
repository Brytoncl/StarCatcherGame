using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour 
{


	private Vector3 movePos;
	public List<SendToRecycler> recycleList;
	private int i = 0;

	void SendThisHandler (SendToRecycler _recycler)
	{
		recycleList.Add (_recycler);
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
		Statics.nextPosition += Statics.distance;
		if (recycleList.Count > 0)
		recycleList.RemoveAt (i);
	}
	

}
