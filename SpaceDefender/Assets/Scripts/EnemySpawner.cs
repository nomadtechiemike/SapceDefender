using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] WaveConfigs0 currentWave;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }
    public WaveConfigs0 GetCurrentWave()
    {
        return currentWave;
    }
    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < currentWave.GetEnemyCount(); i++)
            Instantiate(currentWave.GetEnemyPrefab(i),
            currentWave.GetStartingWaypoint().position,
            Quaternion.identity, transform);
        yield return new WaitForSeconds(currentWave.GetRandomSpawnTime());
    }
}
