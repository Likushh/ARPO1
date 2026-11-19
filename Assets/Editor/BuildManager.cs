using UnityEditor;
<<<<<<< HEAD
using UnityEngine;
using UnityEditor.Build.Reporting; // Обязательно для работы BuildReport
=======
using UnityEditor.Build.Reporting;
using UnityEngine;
>>>>>>> 0222849ac01d7e0f0dd688b0c513cb7a272fa592

public static class BuildManager
{
    private static readonly string WebGLBuildPath = "Builds/WebGL";

<<<<<<< HEAD
=======
    [MenuItem("CI/CD/Build WebGL")]
>>>>>>> 0222849ac01d7e0f0dd688b0c513cb7a272fa592
    public static void BuildWebGL()
    {
        Debug.Log("[CI/CD] Запущен автоматический процесс сборки WebGL...");

<<<<<<< HEAD
        // 1. Получаем список сцен
=======
>>>>>>> 0222849ac01d7e0f0dd688b0c513cb7a272fa592
        string[] levels = GetScenes();
        if (levels.Length == 0)
        {
            Debug.LogError("[CI/CD] Ошибка: В Настройках Сборки (Build Settings) не найдено ни одной активной сцены!");
            ExitWithCode(1);
            return;
        }

<<<<<<< HEAD
        // 2. Конфигурируем параметры сборки
=======
>>>>>>> 0222849ac01d7e0f0dd688b0c513cb7a272fa592
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = levels,
            locationPathName = WebGLBuildPath,
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

<<<<<<< HEAD
        // 3. Запускаем компиляцию
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        // 4. Анализируем результаты
        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log($"[CI/CD] УСПЕХ! WebGL билд успешно создан.");
=======
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("[CI/CD] УСПЕХ! WebGL билд успешно создан.");
>>>>>>> 0222849ac01d7e0f0dd688b0c513cb7a272fa592
            Debug.Log($"[CI/CD] Время сборки: {summary.totalTime.TotalSeconds:F2} сек. Размер: {summary.totalSize} байт.");
            ExitWithCode(0);
        }
        else
        {
            Debug.LogError($"[CI/CD] ОШИБКА СБОРКИ! Количество ошибок: {summary.totalErrors}");
            ExitWithCode(1);
        }
    }

    private static string[] GetScenes()
    {
        var editorScenes = EditorBuildSettings.scenes;
        int activeCount = 0;
        foreach (var scene in editorScenes)
        {
            if (scene.enabled) activeCount++;
        }

        string[] scenePaths = new string[activeCount];
        int index = 0;
        foreach (var scene in editorScenes)
        {
            if (scene.enabled)
            {
                scenePaths[index] = scene.path;
                index++;
            }
        }
        return scenePaths;
    }

    private static void ExitWithCode(int code)
    {
<<<<<<< HEAD
        if (System.Environment.CommandLine.Contains("-batchmode"))
            EditorApplication.Exit(code);
=======
        if (Application.isBatchMode)
        {
            EditorApplication.Exit(code);
        }
>>>>>>> 0222849ac01d7e0f0dd688b0c513cb7a272fa592
    }
}