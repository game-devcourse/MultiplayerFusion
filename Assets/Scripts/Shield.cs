using Fusion;
using System.Collections;
using UnityEngine;

public class Shield : NetworkBehaviour
{
    private bool hasShield = false;

    public void ActivateShield(float shieldDuration)
    {
        if (!hasShield)
        {
            StartCoroutine(ShieldDuration(shieldDuration));
        }
    }

    private IEnumerator ShieldDuration(float shieldDuration)
    {
        hasShield = true;

        yield return new WaitForSeconds(shieldDuration);

        hasShield = false;
    }

    public bool HasShield()
    {
        return hasShield;
    }
}
