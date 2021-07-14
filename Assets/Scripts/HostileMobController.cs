using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Minecraft
{
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(RigidbodyMovement))]
    public class HostileMobController : MonoBehaviour
    {
        public HostileMob Object;
        private NavMeshAgent agent;
        private RigidbodyMovement rbMovement;

        private Player target;
        private Player[] Players => _players ??= FindObjectsOfType<Player>();
        private Player[] _players;

        private void Awake()
        {
            rbMovement = GetComponent<RigidbodyMovement>();
            agent = GetComponent<NavMeshAgent>();
        }

        private void Start()
        {
            FindTarget();
        }

        private void FindTarget()
        {
            var closestDistance = float.MaxValue;
            foreach (var player in Players)
            {
                var distance = Vector3.Distance(transform.position, player.transform.position);
                if (!(distance <= closestDistance) || !(distance <= Object.Range)) continue;
                target = player;
                closestDistance = distance;
            }
            rbMovement.MoveTo(target.transform.position);
            Debug.Log(target.transform.position);
        }

        private NavMeshPath _cachedPath;
        private Coroutine _MoveToTarget;
        private void Update()
        {
            var path = new NavMeshPath();
            if (!agent.CalculatePath(target.transform.position, path) || path == _cachedPath) return;
            _cachedPath = path;
            if (_MoveToTarget != null)
            {
                pointInPath = 0;
                StopCoroutine(_MoveToTarget);
                _MoveToTarget = null;
            }
            _MoveToTarget = StartCoroutine(MoveToTarget());
        }

        private int pointInPath;
        private IEnumerator MoveToTarget()
        {
            pointInPath = _cachedPath.corners.Length - 1;
            while (pointInPath > 0)
            {
                rbMovement.MoveTo(_cachedPath.corners[pointInPath]);
                yield return new WaitUntil(() => rbMovement.IsAtDestination);
                pointInPath--;
            }
        }
    }
}