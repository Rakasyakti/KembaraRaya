using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI TextKoin;
    // Start is called before the first frame update
    void Start()
    {
        TextKoin = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTextKoin(PlayerInventory PlayerInventory)
    {
        TextKoin.text = PlayerInventory.JumlahKoin.ToString();
    }
}
