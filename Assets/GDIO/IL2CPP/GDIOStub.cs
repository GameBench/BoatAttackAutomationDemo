#if GDIO_UNITY_NEW_INPUT_IL2CPP
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using static UnityEngine.InputSystem.LowLevel.InputEventTrace;

public class GDIOStub : MonoBehaviour
{
	[UnityEngine.Scripting.Preserve]
	public void GDIOStubCall()
	{

	        Type t = typeof(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.KeyboardState, double>);
        	Type t2 = typeof(System.Action<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.MouseState, double>);
		Type t3 = typeof(InternedString);
		Type t4 = typeof(UnityEngine.InputSystem.InputSystem);
	        Type t5 = typeof(UnityEngine.InputSystem.InputDevice);

	        Type t8 = typeof(System.Action<System.Object, UnityEngine.InputSystem.LowLevel.KeyboardState, double>);
        	Type t9 = typeof(System.Action<System.Object, UnityEngine.InputSystem.LowLevel.MouseState, double>);

	        object a = System.Runtime.Serialization.FormatterServices.GetUninitializedObject(t8);
        	object b = System.Runtime.Serialization.FormatterServices.GetUninitializedObject(t9);

	        UnityEngine.InputSystem.InputSystem.QueueStateEvent<UnityEngine.InputSystem.LowLevel.KeyboardState>((InputDevice)null, (KeyboardState)new KeyboardState(), -1d);
		UnityEngine.InputSystem.InputSystem.QueueStateEvent<UnityEngine.InputSystem.LowLevel.MouseState>((InputDevice)null, (MouseState)new MouseState(), -1d);
		UnityEngine.InputSystem.InputSystem.QueueStateEvent((InputDevice)null, (KeyboardState)new KeyboardState(), -1d);
		UnityEngine.InputSystem.InputSystem.QueueStateEvent((InputDevice)null, (MouseState)new MouseState(), -1d);
		UnityEngine.InputSystem.InputSystem.QueueStateEvent<UnityEngine.InputSystem.LowLevel.MouseState>((InputDevice)null, (MouseState)new MouseState(), -1d);
		UnityEngine.InputSystem.InputSystem.RegisterLayout("","",null);
		UnityEngine.InputSystem.InputSystem.AddDevice("","", null);
        	UnityEngine.InputSystem.InputSystem.AddDevice<InputDevice>();
	        UnityEngine.InputSystem.InputSystem.AddDevice((InputDevice)null);
		UnityEngine.InputSystem.InputSystem.AddDevice(new UnityEngine.InputSystem.Layouts.InputDeviceDescription());
		UnityEngine.InputSystem.InputSystem.AddDevice(string.Empty);
        	UnityEngine.InputSystem.InputSystem.AddDeviceUsage(null, "");
		UnityEngine.InputSystem.InputSystem.RemoveLayout("");
		UnityEngine.InputSystem.InputSystem.GetDevice<InputDevice>("");
		UnityEngine.InputSystem.InputSystem.GetDevice(string.Empty);
		UnityEngine.InputSystem.InputSystem.GetDevice(typeof(InputDevice));

	}
}
#endif