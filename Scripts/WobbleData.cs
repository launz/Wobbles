using UnityEngine;

// WobbleData.value is used to follow another value based on predefined stiffness and damping.
[System.Serializable]
public class WobbleData
{
    [HideInInspector]
    public float value = 0f, velocity = 0f, dampingFactor = 0f, acceleration = 0f;
    [Header("Parameters")]
    public float stiffness = 160f;
    public float damping = 10f;
}

// 2D WobbleData
[System.Serializable]
public class WobbleData2
{
    public WobbleData wobbleDataX;
    public WobbleData wobbleDataY;
    public WobbleData2()
    {
        wobbleDataX = new WobbleData();
        wobbleDataY = new WobbleData();
    }
}

// 3D WobbleData
[System.Serializable]
public class WobbleData3
{
    public WobbleData wobbleDataX;
    public WobbleData wobbleDataY;
    public WobbleData wobbleDataZ;
    public WobbleData3()
    {
        wobbleDataX = new WobbleData();
        wobbleDataY = new WobbleData();
        wobbleDataZ = new WobbleData();
    }
}
