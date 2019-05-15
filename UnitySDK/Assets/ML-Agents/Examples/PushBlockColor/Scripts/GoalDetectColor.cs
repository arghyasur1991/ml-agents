//Detect when the orange block has touched the goal. 
//Detect when the orange block has touched an obstacle. 
//Put this script onto the orange block. There's nothing you need to set in the editor.
//Make sure the goal is tagged with "goal" in the editor.

using UnityEngine;

public class GoalDetectColor : MonoBehaviour
{
    [HideInInspector]
    /// <summary>
    /// The associated agent.
    /// This will be set by the agent script on Initialization. 
    /// Don't need to manually set.
    /// </summary>
	public PushAgentBasicColor agent;  //

    void OnCollisionEnter(Collision col)
    {
        // Touched goal.
        if (col.gameObject.CompareTag("redGoal"))
        {
            Debug.Log("red");
            agent.IScoredAGoal(agent.selection != 0);
        }

        if (col.gameObject.CompareTag("orangeGoal"))
        {
            Debug.Log("orange");
            agent.IScoredAGoal(agent.selection != 1);
        }
    }
}
