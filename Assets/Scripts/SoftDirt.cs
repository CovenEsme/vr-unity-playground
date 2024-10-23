using UnityEngine;

public class SoftDirt : MonoBehaviour
{
    [SerializeField] private bool hasBeenShovelled = false;
    [SerializeField] private float destroySpeed = 0.3f;

    private Vector3 initScale;

    private void Awake()
    {
        initScale = transform.localScale;
    }

    public void DoShovel()
    {
        hasBeenShovelled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasBeenShovelled) {
            float reduceVec = destroySpeed * Time.deltaTime;
            gameObject.transform.localScale -= new Vector3(reduceVec, reduceVec, reduceVec);

            if (gameObject.transform.localScale.magnitude < (initScale / 10).magnitude) {
                Destroy(gameObject);
            }
        }
    }
}
