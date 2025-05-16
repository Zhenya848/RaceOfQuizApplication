using TMPro;
using UnityEngine;

public class LimitTimeScript : MonoBehaviour
{
    [SerializeField] private GameObject _isTimeNotLimited;
    [SerializeField] private GameObject _isTimeLimited;

    [SerializeField] private TextMeshProUGUI _seconds;
    [SerializeField] private TextMeshProUGUI _minutes;
    [SerializeField] private TextMeshProUGUI _hours;

    public void GetLimitTimeActive(bool isActive)
    {
        _isTimeLimited.SetActive(isActive);
        _isTimeNotLimited.SetActive(!isActive);
    }

    public void SetLimitTime(uint seconds, uint minutes, uint hours)
    {
        _seconds.text = $"������: {seconds}";
        _minutes.text = $"�����: {minutes}";
        _hours.text = $"�����: {hours}";

        GetLimitTimeActive(true);
    }
}
