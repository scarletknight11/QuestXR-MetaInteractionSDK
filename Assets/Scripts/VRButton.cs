using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class VRButton : MonoBehaviour {

    public UnityEvent onPressed, onReleased;

   
    public void InaitilizeButton()
    {
        onPressed.Invoke();
    }

}
