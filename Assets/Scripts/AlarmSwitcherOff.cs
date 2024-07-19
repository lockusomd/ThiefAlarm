using UnityEngine;

public class AlarmSwitcherOff : MonoBehaviour
{
    [SerializeField] private Alarm _alarm;
    private float _stepVolume = -0.2f;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent<Thief>(out Thief thief))
            _alarm.ChangeVolumeStep(_stepVolume);
    }
}
