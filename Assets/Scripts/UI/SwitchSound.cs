using UnityEngine;

public class SwitchSound : MonoBehaviour
{
    [SerializeField] private AudioSource _backgroundSound;
    [SerializeField] private AudioSource _shotSound;
    public void SwitchOff()
    {
        _backgroundSound.enabled = false;
        _shotSound.enabled = false;
    }
    public void SwitchOn()
    {
        _backgroundSound.enabled = true;
        _shotSound.enabled = true;
    }
}
