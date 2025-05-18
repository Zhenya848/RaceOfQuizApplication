using UnityEngine.UI;
using UnityEngine;

public class PagesBackgroundAnimationScript : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;

    [SerializeField] private Image _backgroundIcon;
    [SerializeField] private bool _animationIsActive;

    private float _maxPosX = 0;
    private float _maxPosY = 0;

    [SerializeField] private float _posOffsetX = 100;
    [SerializeField] private float _posOffsetY = 100;

    private float _currentPosX = 0;
    private float _currentPosY = 0;

    private void Start()
    {
        _maxPosX = _rectTransform.position.x - _backgroundIcon.rectTransform.rect.width / 2;
        _maxPosY = _rectTransform.position.y - _backgroundIcon.rectTransform.rect.height / 2;

        _currentPosX = -_maxPosX;
        _currentPosY = -_maxPosY;

        SpawnRow();
    }

    private void SpawnRow()
    {
        while (_currentPosX < _maxPosX)
        {
            var position = new Vector3(_currentPosX, _currentPosY);

            var icon = Instantiate(_backgroundIcon.gameObject, transform);
            icon.transform.localPosition = position;

            _currentPosX += _posOffsetX;
        }
    }
}