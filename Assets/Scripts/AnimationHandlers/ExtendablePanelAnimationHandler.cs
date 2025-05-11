using System.Collections;
using UnityEngine;

public class ExtendablePanelAnimationHandler : AnimationHandlerBase
{
    protected override void StartAnim()
    {
        var parameterName = "ExtendablePanelIsActive";
        var parameterValue = _animator.GetBool(parameterName);

        _animator.SetBool(parameterName, !parameterValue);
    }
}
