using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DefaultNamespace

{
    public class ExitClickEventListener : MonoBehaviour,IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            print("Exit game");


            if (eventData.clickCount ==2)
            {
                print("double click Exit game");
            }
        }
    }
}