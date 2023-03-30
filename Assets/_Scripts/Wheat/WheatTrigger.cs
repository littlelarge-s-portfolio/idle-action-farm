using UnityEngine;

public class WheatTrigger : MonoBehaviour
{
    #region Variables
    private Wheat _wheat;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _wheat = GetComponentInParent<Wheat>();
    }

    private void OnTriggerStay(Collider other)
    {
        IPlantState state = _wheat.StateManager.GetCurrentState();

        if (other.transform.TryGetComponent<ICutter>(out ICutter cutter) && state is IPlantCollisionStayState)
        {
            IPlantStateful stateful = _wheat.StateManager;

            ((IPlantCollisionStayState) state).OnCollisionStay(stateful, cutter);
        }
    }
    #endregion
}