using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayYoutubeAudio : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    AudioClip audioClip;
    string http;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(GetAudio());
    }
    public void ReadStringInput(string s)
    {
        http = s;
        Debug.Log(http);
    }

    IEnumerator GetAudio()
    {
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(
            http, AudioType.MPEG))
        {
            yield return www.SendWebRequest();
            // NOLINTNEXTLINE
            if (www.isNetworkError)
            {
                Debug.Log(www.error);
            }
            else
            {
                audioClip = DownloadHandlerAudioClip.GetContent(www);
                audioSource.clip = audioClip;
                audioSource.Play();
                Debug.Log(http + " Playing");
            }
        }
    }
    public void playwwwAudio()
    {
        audioSource.Play();
    }
}
