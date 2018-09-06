using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class GoogleMobileAdsDemoScript : MonoBehaviour {
	private BannerView bannerView;

	// Use this for initialization
	void Start () {
		this.RequestBanner ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void RequestBanner()
	{
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-8812320259916523/7946138865";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-3940256099942544/2934735716";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();

		// Load the banner with the request.
		bannerView.LoadAd(request);
	}
}
