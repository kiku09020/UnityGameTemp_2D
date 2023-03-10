using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioListener))]
public class AudioController : Singleton<AudioController>
{

    /// <summary>
    /// 全ての音声を一時停止
    /// </summary>
    public static void PauseAllAudio()
    {
        BGM.Instance.Pause();
        SE.Instance.Pause();
    }

    /// <summary>
    /// 全ての音声の一時停止を解除
    /// </summary>
    public static void UnPauseAllAudio()
    {
        BGM.Instance.UnPause();
        SE.Instance.UnPause();
    }

    /// <summary>
    /// 全ての音声を停止
    /// </summary>
    public static void StopAllAudio()
    {
        BGM.Instance.Stop();
        SE.Instance.Stop();
    }
}
