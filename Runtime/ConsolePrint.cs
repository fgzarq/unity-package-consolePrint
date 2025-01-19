using UnityEngine;

namespace Fgzarq.ConsolePrint
{
	public class ConsolePrint : MonoBehaviour
	{
		[SerializeField] string text = "Default text value";

		void Start()
		{
			Debug.Log(text);
		}
	}
}