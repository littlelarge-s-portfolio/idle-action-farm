using UnityEngine;

public class Wheat : MonoBehaviour, IPlant
{
    #region Variables
    private WheatStateManager _wheatStateManager;
    private WheatData _wheatData;
    private WheatUIManager _wheatUIManager;
    private ICutter _cutter;

    public WheatStateManager StateManager { get { return _wheatStateManager; } }
    public IPlantData Data { get { return _wheatData; } }
    public IPlantUIManager UIManager { get { return _wheatUIManager; } }
    public ICutter Cutter { get { return _cutter; } set { _cutter = value; } }
    #endregion

    #region UnityMethods
    public void Awake()
    {
        _wheatStateManager = GetComponent<WheatStateManager>();
        _wheatData = GetComponent<WheatData>();
        _wheatUIManager = GetComponentInChildren<WheatUIManager>();
    }
    #endregion

    #region Methods
    public void SpawnPlantBlock()
    {
        Rigidbody wheatBlock = Instantiate(_wheatData.PrefabData.PlantBlock, transform.position, Quaternion.identity).GetComponent<Rigidbody>();

        float force = 5f;
        float randomizeValue = 25;

        Vector3 randomDirection = new Vector3(Random.Range(-randomizeValue, randomizeValue), 1, Random.Range(-randomizeValue, randomizeValue));

        wheatBlock.AddForce(randomDirection * force);
    }

    public Transform GetTransform()
    {
        return transform;
    }
    #endregion
}