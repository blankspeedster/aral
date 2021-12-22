using UnityEngine.Audio;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{

  public AudioMixer mainMixer;
  public void SetQuality(int qualityIndex)
  {
      QualitySettings.SetQualityLevel(qualityIndex);
  }
  public void SetVolume(float volume)
  {
      mainMixer.SetFloat("volume", volume);
  }
}
