using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobblesExample : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform follower;
    [SerializeField] Transform leader;

    [Header("Parameters")]
    [SerializeField] WobbleData wobbleData;

    private void Start() 
    {
        StartCoroutine(MoveLeaderCR());
    }

    private IEnumerator MoveLeaderCR() 
    {
        float timeElapsed = 0f;
        float duration = .15f;
        float progress = 0f;
        Vector3 startPos = leader.position;
        Vector3 endPos =  new Vector3 (leader.position.x, 1f, Random.Range(-4.5f, 4.5f));

        while(timeElapsed < duration) 
        {
            timeElapsed += Time.deltaTime;
            progress = timeElapsed/ duration;
            leader.position = Vector3.Lerp(startPos, endPos, progress);
            yield return 0;
        }

        StartCoroutine(Wait());
        yield return null;
    }

    private IEnumerator Wait() 
    {
        float timeElapsed = 0f;
        float duration = Random.Range(0.5f, 1.5f);

        while(timeElapsed < duration) 
        {
            timeElapsed += Time.deltaTime;
            yield return 0;
        }

        StartCoroutine(MoveLeaderCR());
        yield return null;
    }

    private void FixedUpdate() 
    {
        MoveFollower();
    }

    void MoveFollower() 
    {
        follower.position =  new Vector3(
            leader.position.x, 
            0f,
            Wobbles.Follow(wobbleData, leader.position.z, Time.fixedDeltaTime)
            );
    }
}
