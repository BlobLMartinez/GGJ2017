using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace JumpLib
{
	public class JLib {

		#region Quick Methods
		public static Vector2 Direction(Vector3 from, Vector3 to){
			return ((Vector2)to - (Vector2)from).normalized;
		}

		public static Vector2 MouseWorldPos()
        {
			return (Vector2)Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}

        public static Vector2 TouchWorldPos()
        {
            return (Vector2)Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        }
        #endregion

        #region Timer
        private static bool timerTest = true;
		private static Dictionary<GameObject, bool> timers = new Dictionary<GameObject, bool>();

		public static bool Timer(float wait,GameObject obj){

			List<GameObject> toRemoveObj = new List<GameObject> ();
			foreach (var iObj in timers.Keys) {
				if (iObj == null) {
					toRemoveObj.Add (iObj);
				}
			}
			for (int index = toRemoveObj.Count - 1; index >= 0; index--) {
				MonoBehaviour.Destroy(toRemoveObj [index]);
			}

			if (timers.ContainsKey (obj)) {
				if (timers[obj]) {
					timers[obj] = false;
					obj.GetComponent<MonoBehaviour>().StartCoroutine (TimerCoroutine (obj,wait));
					return true;
				} else {
					return false;
				}
			} else {
				timers.Add (obj, true);
				return true;
			}
		}

		private  static IEnumerator TimerCoroutine(GameObject pObj, float pWait){
			yield return new WaitForSeconds (pWait);
			timers [pObj] = true;
		}
		#endregion

		#region cameraShake
		private static  float maxShakeDuration = 1f;
		private static  float shakeAmount = 0.2f;
		private static  float decreaseFactor = 1.0f;
		private static  Vector3 originalPos;

		public static void CameraShake(){
			originalPos = Camera.main.transform.localPosition;
			GameObject.FindGameObjectWithTag("Player").GetComponent<MonoBehaviour>().StartCoroutine (shakeItOut (Camera.main.transform));
		}

		private static IEnumerator shakeItOut (Transform cameraTr){
			float shakeDuration = maxShakeDuration;
			while(shakeDuration > 0){
				cameraTr.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
				shakeDuration -= Time.deltaTime * decreaseFactor;
				yield return null;
			}
			shakeDuration = maxShakeDuration;
			cameraTr.localPosition = originalPos;
		}
		#endregion

	}
}
