using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    private static int _nextLevelIndex =1;

    private void OnEnable()
    {
      _enemies = FindObjectsOfType<Enemy>();
    }

    void Update()
    {
      foreach (Enemy enemy in _enemies)
      {
        if (enemy != null)
        return;
      }

      Debug.Log ("Bsahtek frr");

      _nextLevelIndex ++;
      string nextLevelName = "Level" + _nextLevelIndex ;
      SceneManager.LoadScene(nextLevelName);
    }
}
