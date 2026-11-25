namespace Impostor.Server.Config
{
    public static class DisconnectMessages
    {
        public const string Error = "服务器发生内部错误。" +
                                    "请查看服务器控制台以获取更多信息。" +
                                    "如果问题持续出现，请在 AmongUsServer 的 GitHub 上反馈。";

        public const string Destroyed = "你尝试加入的游戏正在被销毁。" +
                                        "请创建一个新游戏。";

        public const string NotImplemented = "运行在服务器重定向模式下的 Impostor 服务器尚未实现游戏列表功能。";

        public const string UsernameLength = "你的用户名太长，请缩短后重试。";

        public const string UsernameIllegalCharacters = "你的用户名包含非法字符，请移除后重试。";
    }
}