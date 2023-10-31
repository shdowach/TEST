using UnityEngine;
public class ShowAds : MonoBehaviour
{
	private static int advCount;

	public void ShowInter()
	{
		advCount++;
		if (advCount % 2 == 0)
		{
		//	Advertisements.Instance.ShowInterstitial();

		}
		Advertisements.Instance.ShowInterstitial();

	}
}
