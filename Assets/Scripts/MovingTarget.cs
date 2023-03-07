using System.Collections;
using System.Linq;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public Transform[] positions;

    public float travelTime = 10;
    public float waitTime = 2;

    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(TravelLoop());
    }

    private IEnumerator TravelLoop()
    {
        while (true)
            for (var i = 0; i < positions.Length; i++)
            {
                var start = i < positions.Length - 1 ? positions[i].position : positions.Last().position;
                var target = i < positions.Length - 1 ? positions[i + 1].position : positions.First().position;

                yield return StartCoroutine(TravelToStation(start, target));
                yield return new WaitForSeconds(waitTime);
            }
    }

    private IEnumerator TravelToStation(Vector3 start, Vector3 target)
    {
        for (float t = 0; t < 1; t += Time.deltaTime / travelTime)
        {
            transform.position = Vector3.Lerp(start, target, t);
            yield return null;
        }
    }
}