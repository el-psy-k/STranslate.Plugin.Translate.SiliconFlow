# STranslate SiliconFlow 翻译插件

基于 SiliconFlow API 的 STranslate 翻译插件。

## 📦 安装

1. 下载最新的 `.spkg` 文件（在 [Releases](https://github.com/el-psy-k/STranslate.Plugin.Translate.SiliconFlow/releases) 页面）
2. 在 STranslate 中进入 **设置** → **插件** → **安装插件**
3. 选择下载的 `.spkg` 文件并重启 STranslate

## ⚙️ 配置

1. **获取 API Key**: 访问 [SiliconFlow](https://siliconflow.cn/) 注册并获取 API Key
2. **配置插件**: 在 STranslate 中进入 **设置** → **服务** → **SiliconFlow** → **设置**
   - **API Key**: 你的 SiliconFlow API Key
   - **API URL**: `https://api.siliconflow.cn`（默认）
   - **模型**: `Qwen/Qwen3.5-4B`
   - **温度**: 0-2，默认 0.7
   - **思考模式**: 选择是否启用思考模式（启用后会在翻译前进行思考分析）

### 提示词模板

支持自定义提示词，内置：
- **翻译** - 专业翻译引擎
- **润色** - 文本润色优化
- **总结** - 文本摘要生成

提示词变量：`$source`（源语言）、`$target`（目标语言）、`$content`（待翻译文本）

## 📄 许可证

[MIT](LICENSE)

---

**Made with ❤️ by [Raiden](https://github.com/el-psy-k)**
