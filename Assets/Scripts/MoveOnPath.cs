using UnityEngine;

public class MoveOnPath : MonoBehaviour
{
	public TransformPathScript PathToFollow;

	public int CurrentWayPointID;

	public float speed;

	private float ReachDistance = 1f;

	public string PathName;

	private Vector3 LastPos;

	private Vector3 CurPos;

	private void Start()
	{
		LastPos = base.transform.position;
	}

	private void Update()
	{
		float num = Vector3.Distance(PathToFollow.path_objs[CurrentWayPointID].position, base.transform.position);
		base.transform.position = Vector3.MoveTowards(base.transform.position, PathToFollow.path_objs[CurrentWayPointID].position, Time.deltaTime * speed);
		if (num <= ReachDistance)
		{
			CurrentWayPointID++;
		}
		if (CurrentWayPointID >= PathToFollow.path_objs.Count)
		{
			CurrentWayPointID = 0;
		}
	}
}
