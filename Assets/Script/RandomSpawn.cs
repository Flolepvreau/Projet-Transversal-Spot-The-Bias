using UnityEngine;
using System.Collections.Generic;

public class RandomSpawn : MonoBehaviour
{
    public GameObject peoplePrefab;
    public int maxPeople = 100;
    public float spawnInterval = 0.01f;
    private int _currentPeople = 0;

    public List<string> names = new List<string>();

    public CameraController camController;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPeople), spawnInterval, spawnInterval);
    }

    void SpawnPeople()
    {
        if (_currentPeople >= maxPeople) return;

        Vector2 spawnPosition = GetRandomPosition();
        GameObject newPeople = Instantiate(peoplePrefab, spawnPosition, Quaternion.identity);

        string name = GetRandomName();
        newPeople.GetComponent<ClickableObject>().objectName = name;

        Color color = GetColor(name);
        newPeople.GetComponent<SpriteRenderer>().color = color;

        _currentPeople++;
    }

    Vector2 GetRandomPosition()
    {
        float x = Random.Range(-camController.worldSize.x / 2, camController.worldSize.x / 2);
        float y = Random.Range(-camController.worldSize.y / 2, camController.worldSize.y / 2);
        return new Vector2(x, y);
    }

    string GetRandomName()
    {
        int id = Random.Range(0, names.Count);
        return names[id];
    }

    Color GetColor(string name)
    {
        switch (name.ToLower())
        {
            case "truc":
                return Color.blue;
            case "chose":
                return Color.red;
            case "machin":
                return Color.green;
            default:
                return Color.white;
        }
    }
}

