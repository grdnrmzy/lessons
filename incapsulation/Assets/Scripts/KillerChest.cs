using Unity.VisualScripting;
using UnityEngine;

class KillerChest : MonoBehaviour, IIdentifiable
{
    private Player _target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _target.Speed * Time.deltaTime * 0.9f);

    }

    public void Action(Player player)
    {
        _target = player;
    }

}

