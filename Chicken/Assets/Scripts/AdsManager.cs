using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class AdsManager : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardedAd rewarded;
    public Text interText;
    public Text rewardText;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        RequestBanner();
        RequestInterstitial();
        RequestRewarded();
    }

    
    private void Update()
    {
        if (interstitial.IsLoaded())
        {
            interText.text = "interAd is READY!!";
            interText.color = Color.green;
        }
        else
        {
            interText.text = "interAd is NOT ready!!";
            interText.color = Color.red;
        }

        if (rewarded.IsLoaded())
        {
            rewardText.text = "rewardedAd is READY!!";
            rewardText.color = Color.green;
        }
        else
        {
            rewardText.text = "rewardedAd is NOT ready!!";
            rewardText.color = Color.red;
        }
    }
    

    public void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-9585251573794462/4711599229";

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

    public void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-9585251573794462/4136884151";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

    public void RequestRewarded()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-9585251573794462/9566795496";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an RewardedAd.
        rewarded = new RewardedAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        rewarded.LoadAd(request);
    }



    public void ShowBannerAd()
    {
        RequestBanner();
    }

    public void ShowInterstitialAd()
    {
        if (interstitial.IsLoaded())
            interstitial.Show();
    }

    public void ShowRewardedAd()
    {
        if (rewarded.IsLoaded())
            rewarded.Show();
    }



}
