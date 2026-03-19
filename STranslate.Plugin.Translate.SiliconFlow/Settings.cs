namespace STranslate.Plugin.Translate.SiliconFlow;

public class Settings
{
    public string ApiKey { get; set; } = string.Empty;
    public string Url { get; set; } = "https://api.siliconflow.cn";
    public string Model { get; set; } = "Qwen/Qwen3.5-4B";
    public List<string> Models { get; set; } =
    [
        "Qwen/Qwen3.5-4B"
    ];
    public double Temperature { get; set; } = 0.7;
    public bool Stream { get; set; } = true;
    public bool Thinking { get; set; } = false;

    public List<Prompt> Prompts { get; set; } =
    [
        new("翻译",
        [
            new PromptItem("system", "You are a professional, authentic translation engine. You only return the translated text, without any explanations."),
            new PromptItem("user", "Please translate  into $target (avoid explaining the original text):\r\n\r\n$content"),
        ], true),
        new("润色",
        [
            new PromptItem("system", "You are a professional, authentic text polishing engine. You only return the polished text, without any explanations."),
            new PromptItem("user", "Please polish the following text in $source (avoid explaining the original text):\r\n\r\n$content"),
        ]),
        new("总结",
        [
            new PromptItem("system", "You are a professional, authentic text summarization engine. You only return the summarized text, without any explanations."),
            new PromptItem("user", "Please summarize the following text in $source (avoid explaining the original text):\r\n\r\n$content"),
        ]),
    ];
}
