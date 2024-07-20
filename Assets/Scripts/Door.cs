using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Alarm _alarm;
    private float _stepVolume = 0.2f;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent<Thief>(out Thief thief))
            _alarm.ChangeVolumeStep(_stepVolume);
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.TryGetComponent<Thief>(out Thief thief) && collider.transform.position.z < transform.position.z)
            _alarm.ChangeVolumeStep(-_stepVolume);
    }
}
