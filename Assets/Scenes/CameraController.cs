using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float rotateSpeedX = 3;
    private float rotateSpeedY = 5;
    private float limitMinX = -80;
    private float limitMaxX = 50;
    private float eulerAngleX;
    private float eulerAngleY;
    
   
    public void RotateTo(float mouseX, float mouseY)
    {
      eulerAngleX += mouseX + rotateSpeedX;
      eulerAngleX -= mouseY 
    }
}
