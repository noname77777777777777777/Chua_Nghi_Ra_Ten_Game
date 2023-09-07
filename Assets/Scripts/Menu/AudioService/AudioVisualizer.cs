using UnityEngine;

public class AudioVisualizer : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject targetObject;

    private void Start()
    {
        // Đảm bảo đã gán AudioSource và targetObject trong Inspector
        if (audioSource == null || targetObject == null)
        {
            Debug.LogError("Please assign AudioSource and targetObject in the Inspector.");
        }
    }

    private void Update()
    {
        // Đọc mức âm thanh từ AudioSource
        float audioLevel = GetAudioLevel();

        // Áp dụng mức âm thanh vào Scale của targetObject
        Vector3 newScale = targetObject.transform.localScale;
        newScale.y = 1f + audioLevel * 5f; // Điều chỉnh Scale theo mức âm thanh
        targetObject.transform.localScale = newScale;
    }

    private float GetAudioLevel()
    {
        // Lấy mức âm thanh từ AudioSource
        float[] spectrum = new float[256];
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
        float audioLevel = 0f;
        for (int i = 0; i < spectrum.Length; i++)
        {
            audioLevel += spectrum[i];
        }
        audioLevel /= spectrum.Length;

        return audioLevel;
    }
}