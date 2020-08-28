using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyMobile;

public class AdsManager : MonoBehaviour
{
    
    void Awake()
    {
        if (!RuntimeManager.IsInitialized())
            RuntimeManager.Init();
    }

    public void ShowBannerAds()
    {
        Advertising.ShowBannerAd(BannerAdPosition.Bottom);
    }

    public void ShowInterstitialAds()
    {
        if (Advertising.IsInterstitialAdReady())
            Advertising.ShowInterstitialAd();
    }

    public void ShowRewardedAds()
    {
        if (Advertising.IsRewardedAdReady())
            Advertising.ShowRewardedAd();
    }
}
