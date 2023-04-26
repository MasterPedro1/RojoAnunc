using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class LogrosManager : MonoBehaviour
{
   public void LogrosId(string achievment)
    {
        Social.ReportProgress(achievment, 100.0f, (bool success) => {
            // handle success or failure
        });
    }
}
