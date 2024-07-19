using UnityEngine;

public class AlarmSwitcherOn : MonoBehaviour
{
    [SerializeField] private Alarm _alarm;
    private float _stepVolume = 0.05f;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.TryGetComponent<Thief>(out Thief thief))
            _alarm.ChangeVolumeStep(_stepVolume);
    }
}
