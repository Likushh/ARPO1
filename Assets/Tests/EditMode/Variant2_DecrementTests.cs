using System.Reflection;
using NUnit.Framework;
using Platformer.Mechanics;
using UnityEngine;

public class Variant2_DecrementTests
{
    [Test]
    public void Decrement_ReducesHPByExactlyOne()
    {
        // 1. Создаем объект
        GameObject playerObj = new GameObject("TestPlayer");
        Health health = playerObj.AddComponent<Health>();

        // 2. Задаем максимальное здоровье
        health.maxHP = 3;

        // 3. ПРИНУДИТЕЛЬНО вызываем Awake() через рефлексию. 
        MethodInfo awakeMethod = typeof(Health).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        if (awakeMethod != null)
        {
            awakeMethod.Invoke(health, null);
        }

        // 4. Находим приватное поле currentHP
        var hpField = typeof(Health).GetField("currentHP",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

        // Проверяем, что здоровье инициализировалось (должно быть 3)
        int hpBefore = (int)hpField.GetValue(health);
        Assert.AreEqual(3, hpBefore, "Ошибка инициализации: здоровье должно быть 3!");

        // 5. Наносим урон
        health.Decrement();

        // 6. Проверяем, что здоровье уменьшилось ровно на 1 (стало 2)
        int hpAfter = (int)hpField.GetValue(health);
        Assert.AreEqual(1, hpAfter, "Ошибка: Decrement() должен уменьшать здоровье ровно на 1!");

        // 7. Убираем за собой (используем DestroyImmediate, так как тест может быть в EditMode)
        Object.DestroyImmediate(playerObj);
    }
}