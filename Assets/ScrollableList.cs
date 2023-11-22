using UnityEngine;

public class ScrollableList : MonoBehaviour
{
    public int numberOfVisibleItems = 3; // Количество видимых элементов
    public Transform[] items;
    private int ClickCount = 0;

    private void Start()
    {
        // Получите все дочерние элементы (предполагается, что они у вас есть)
        //items = new Transform[transform.childCount];
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    items[i] = transform.GetChild(i);
        //}

        // Начните с отображения первых numberOfVisibleItems элементов
        ShowItems(ClickCount, numberOfVisibleItems);
    }

    private void Update()
    {
        // Добавьте логику для сдвига элементов влево и скрытия первого элемента
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ClickCount += 3; 
            ScrollLeft(ClickCount);

        }
    }

    private void ShowItems(int startIndex, int count)
    {
        // Показать count элементов, начиная с startIndex
        for (int i = 0; i < items.Length; i++)
        {
            items[i].gameObject.SetActive(i >= startIndex && i < startIndex + count);
        }
    }

    private void ScrollLeft(int click)
    {
        // Сдвинуть элементы влево, скрыв первый и показывая следующий
        for (int i = 0; i < items.Length - 1; i++)
        {
            items[i].position = items[i + 1].position;
        }

        // Показать новый элемент
        items[items.Length - 1].position = items[items.Length - 2].position + Vector3.right;
        ShowItems(click, numberOfVisibleItems);
    }
}