using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobblesExample2 : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform follower;
    [SerializeField] Transform leader;

    [Header("Parameters")]
    [SerializeField] WobbleData2 wobbleData2;

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
        Vector3 endPos =  new Vector3 (Random.Range(-4.5f, 4.5f), 1f, Random.Range(-4.5f, 4.5f));

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
        Vector2 leaderPos = new Vector2 (leader.position.x, leader.position.z);
        Vector2 newPos = Wobbles.Follow(wobbleData2, leaderPos, Time.fixedDeltaTime);

        follower.position =  new Vector3(
            newPos.x, 
            0f,
            newPos.y
            );
    }
}
