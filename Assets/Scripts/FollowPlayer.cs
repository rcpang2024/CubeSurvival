using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent theEnemy;
    public Transform thePlayer;
    public GameObject levelCompleteUI;

    void Start()
    {
        theEnemy = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (levelCompleteUI.activeSelf)
        {
            theEnemy.isStopped = true;
        }
        theEnemy.SetDestination(thePlayer.position);
    }
}
