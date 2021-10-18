using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class ADSManager : MonoBehaviour
{
    private BannerView banner;
    // test ID ca-app-pub-3940256099942544/6300978111
    const string adUnitID = "ca-app-pub-2872685892021717/8574877130";

    private InterstitialAd interstitial;
    // test ID 	ca-app-pub-3940256099942544/1033173712
    const string adUnitID_inter = "ca-app-pub-2872685892021717/5472063467";



    void OnDisable()
    {
        this.interstitial.OnAdClosed -= HandleOnAdClosed;
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
        StartCoroutine(TimerView());
    }

    private IEnumerator TimerView()      //дефиниция
    {
        yield return new WaitForSeconds(0.01f);
        Time.timeScale = 0;
    }

    void Start()
    {
        MobileAds.Initialize(initStatu => { });
        InterstitialLoad();
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        ShowBanner();
    }


    private void InterstitialLoad()
    {
        interstitial = new InterstitialAd(adUnitID_inter);

        AdRequest request = new AdRequest.Builder().Build();

        interstitial.LoadAd(request);
    }

    public void ShowInterstitial()
    {


        if (interstitial.IsLoaded())
        {
            interstitial.Show();
            InterstitialLoad();
        }
    }

    private void ShowBanner()
    {
        banner = new BannerView(adUnitID, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        banner.LoadAd(request);

    }


}
