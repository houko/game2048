using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DefaultNamespace

{
    public class MenuClickEventListener : MonoBehaviour,IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            print("menu");


            if (eventData.clickCount ==2)
            {
                print("double click menu");
            }
        }
    }
}