using Fusion;
using UnityEngine;

public class ShieldSpawner : NetworkBehaviour
{
    public float protectionDuration = 10f;
    public string tagName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagName))
        {
           GameObject playerObject = other.gameObject;
            if (playerObject != null)
            {
                // Check if the GameObject has a "Shield" component or another relevant component
                // and activate shield accordingly.
                Shield shieldComponent = playerObject.GetComponent<Shield>();

                if (shieldComponent != null)
                {
                    shieldComponent.ActivateShield(protectionDuration);
                }
                Destroy(gameObject);
            }
        }
    }
}