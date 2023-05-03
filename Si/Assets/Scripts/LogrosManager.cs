using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;

public class LogrosManager : MonoBehaviour
{
    public void LogrosId(string achievment)
    {
        Social.ReportProgress(achievment, 100.0f, (bool success) =>
        {
            // handle success or failure
        });
    }

    public void Start()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }

    internal void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            Debug.Log("Exite");
        }
        else
        {
            Debug.Log("Exiten´t");
        }
    }
}