using UnityEngine;

public class Wobbles : MonoBehaviour
{
    /// <summary>
    /// Make wobbleData_.value follow targetValue_ like a spring.
    /// </summary>
    /// <param name="wobbleData_"></param>
    /// <param name="targetValue_"></param>
    /// <param name="deltaTime_"></param>
    /// <returns></returns>
    public static float Follow(WobbleData wobbleData_, float targetValue_, float deltaTime_) 
    {
        wobbleData_.dampingFactor = Mathf.Max (0, 1 - wobbleData_.damping * Time.fixedDeltaTime);
        wobbleData_.acceleration = (targetValue_ - wobbleData_.value) * wobbleData_.stiffness * deltaTime_;
        wobbleData_.velocity = wobbleData_.velocity * wobbleData_.dampingFactor + wobbleData_.acceleration;
        wobbleData_.value += wobbleData_.velocity * Time.fixedDeltaTime;

        if (Mathf.Abs (wobbleData_.value - targetValue_) < 0.001f && Mathf.Abs (wobbleData_.velocity) < 0.001f) {
            wobbleData_.value = targetValue_;
            wobbleData_.velocity = 0f;
        }
       
        return wobbleData_.value;
    }

    /// <summary>
    /// Make wobbleData2.values follow a Vector2 like a spring.
    /// </summary>
    /// <param name="wobbleData2_">wobbleData2 that follows</param>
    /// <param name="targetVector2_">Target Vector2</param>
    /// <param name="deltaTime_">Time Step.</param>   
    /// <returns>the updated Vector2</returns>
    public static Vector2 Follow(WobbleData2 wobbleData2_, Vector2 targetVector2_, float deltaTime_) 
    {
        Follow(wobbleData2_.wobbleDataX, targetVector2_.x, deltaTime_);
        Follow(wobbleData2_.wobbleDataY, targetVector2_.y, deltaTime_);

        return new Vector2(
            wobbleData2_.wobbleDataX.value, 
            wobbleData2_.wobbleDataY.value);
    }

    /// <summary>
    /// Make wobbleData3.values follow a Vector3 like a spring.
    /// </summary>
    /// <param name="wobbleData3_">wobbleData3 that follows</param>
    /// <param name="targetVector3_">Target Vector3</param>
    /// <param name="deltaTime_">Time Step.</param>   
    /// <returns>the updated Vector3</returns>
    public static Vector3 Follow(WobbleData3 wobbleData3_, Vector3 targetVector3_, float deltaTime_) 
    {
        Follow(wobbleData3_.wobbleDataX, targetVector3_.x, deltaTime_);
        Follow(wobbleData3_.wobbleDataY, targetVector3_.y, deltaTime_);
        Follow(wobbleData3_.wobbleDataZ, targetVector3_.z, deltaTime_);

        return new Vector3(
            wobbleData3_.wobbleDataX.value, 
            wobbleData3_.wobbleDataY.value, 
            wobbleData3_.wobbleDataZ.value);
    }
}
