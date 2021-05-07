using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] shuttlePlaceholders;
    public Sprite iconShuttleColour;
    public Sprite iconShuttleGrey;
    public void OnChangeShuttleTotal(int ShuttleTotal)
    {
        for (int i = 0; i < shuttlePlaceholders.Length; ++i)
        {
            if (i < ShuttleTotal)
                shuttlePlaceholders[i].sprite = iconShuttleColour;
            else
                shuttlePlaceholders[i].sprite = iconShuttleGrey;
        }
    }
}