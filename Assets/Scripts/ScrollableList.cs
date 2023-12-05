using UnityEngine;

public class ScrollableList : MonoBehaviour
{
    public int numberOfVisibleItems = 3; // ���������� ������� ���������
    public Transform[] items;
    private int ClickCount = 0;

    private void Start()
    {
        // �������� ��� �������� �������� (��������������, ��� ��� � ��� ����)
        //items = new Transform[transform.childCount];
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    items[i] = transform.GetChild(i);
        //}

        // ������� � ����������� ������ numberOfVisibleItems ���������
        ShowItems(ClickCount, numberOfVisibleItems);
    }

    private void Update()
    {
        // �������� ������ ��� ������ ��������� ����� � ������� ������� ��������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ClickCount += 3; 
            ScrollLeft(ClickCount);

        }
    }

    private void ShowItems(int startIndex, int count)
    {
        // �������� count ���������, ������� � startIndex
        for (int i = 0; i < items.Length; i++)
        {
            items[i].gameObject.SetActive(i >= startIndex && i < startIndex + count);
        }
    }

    private void ScrollLeft(int click)
    {
        // �������� �������� �����, ����� ������ � ��������� ���������
        for (int i = 0; i < items.Length - 1; i++)
        {
            items[i].position = items[i + 1].position;
        }

        // �������� ����� �������
        items[items.Length - 1].position = items[items.Length - 2].position + Vector3.right;
        ShowItems(click, numberOfVisibleItems);
    }
}