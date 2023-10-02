using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Figure : MonoBehaviour
{
    bool isActive;

    private Rigidbody rigidBody;
    [SerializeField] private float speed;

    [SerializeField] Text text;


    void Start()
    {
        isActive = false;
        rigidBody = GetComponent<Rigidbody>();
    }

    public void ChangeAct()
    {
        isActive = !isActive;

        string s = "�� �������(";

        if (isActive) s = "�������!!!!!!";

        text.text = s;
        
    }

    private void FixedUpdate()
    {
        if (isActive)
        {
            Move();
        }
    }


    private void Move()
    {

        // ���������
        Vector3 direction;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        direction.z = 0;

        
        // �������� �� fixedDeltaTime, ����� ���������� �� �������� �� ������� ����������
        rigidBody.MovePosition(rigidBody.position + direction * speed * Time.fixedDeltaTime);

        
    }
}
