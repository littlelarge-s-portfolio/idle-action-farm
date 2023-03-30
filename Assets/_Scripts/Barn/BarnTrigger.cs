using UnityEngine;

public class BarnTrigger : MonoBehaviour
{
    #region Variables
    private Barn _barn;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _barn = FindObjectOfType<Barn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.TryGetComponent<ITradeable>(out ITradeable tradeable))
        {
            tradeable.SellAll(_barn);
        }
    }
    #endregion
}