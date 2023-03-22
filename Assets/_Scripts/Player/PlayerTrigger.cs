using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour
{
    #region Variables
    private Player _player;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.TryGetComponent<IItem>(out IItem item))
        {
            item.Up(_player.Inventory);
        }
    }
    #endregion
}

