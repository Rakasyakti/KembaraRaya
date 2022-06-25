using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    
    public int JumlahKoin { get; private set; }

    public UnityEvent<PlayerInventory> OnKoinTerkumpul; 
    public void KoinTerkumpul()
    {
        JumlahKoin++;
        OnKoinTerkumpul.Invoke(this);
    }
}
