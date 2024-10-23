using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactDirt : MonoBehaviour
{
    // How much should be added to the amountCleaned
    [SerializeField] private float cleaningRate;

    // How much the dirt has been cleaned. Starts at 0.0 and ends at 1.0
    [SerializeField] private float amountCleaned = 0.0f;

    private Vector3 initialScale;

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    private void UpdateScaleFromCleaning()
    {
        transform.localScale = initialScale * (1.0f - amountCleaned);
    }

    public void Clean()
    {
        amountCleaned += cleaningRate;
        UpdateScaleFromCleaning();

        Debug.Log($"Amount: {amountCleaned}; Scale: {gameObject.transform.localScale}");
    }

    private void Update()
    {
        if (amountCleaned >= 0.9f)
        {
            Clean();

            if (amountCleaned >= 1.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
