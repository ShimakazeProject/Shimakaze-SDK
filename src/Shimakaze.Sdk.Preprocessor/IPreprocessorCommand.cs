namespace Shimakaze.Sdk.Preprocessor;

/// <summary>
/// Ԥ����������ӿ�
/// </summary>
public interface IPreprocessorCommand
{
    /// <summary>
    /// Ԥ������������
    /// </summary>
    string Command { get; }
    /// <summary>
    /// ��ʼ������
    /// </summary>
    /// <param name="preprocessor">Ԥ������ʵ��</param>
    Task InitializeAsync(Preprocessor preprocessor!!) => Task.CompletedTask;

    /// <summary>
    /// Ԥ����������ִ��
    /// </summary>
    /// <param name="args">�������</param>
    /// <param name="preprocessor">Ԥ������ʵ��</param>
    /// <returns></returns>
    Task ExecuteAsync(string[] args, Preprocessor preprocessor);

    /// <summary>
    /// ��Ҫ����
    /// </summary>
    bool IsPostProcessing => false;

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="preprocessor">Ԥ������ʵ��</param>
    Task PostProcessingAsync(Preprocessor preprocessor!!) => Task.CompletedTask;
}
