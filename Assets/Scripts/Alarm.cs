using System.Collections;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    private float _stepVolume = 0;
    private Coroutine _coroutine;

    private void Start()
    {
        _audioSource.volume = 0;

        _audioSource.Play();
    }

    private IEnumerator ChangeVolume()
    {
        bool isWork = true;
        WaitForSeconds delay = new WaitForSeconds(0.5f);

        while (isWork)
        {
            _audioSource.volume += _stepVolume;

            if (_audioSource.volume >= 1 || _audioSource.volume <= 0)
                isWork = false;

            yield return delay;
        }
    }

    public void ChangeVolumeStep(float stepVolume)
    {
        if(_coroutine != null)
            StopCoroutine(_coroutine);

        _stepVolume = stepVolume;

        _coroutine = StartCoroutine(ChangeVolume());
    }
}