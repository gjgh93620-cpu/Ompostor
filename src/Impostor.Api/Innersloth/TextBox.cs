namespace Impostor.Api.Innersloth
{
    public static class TextBox
    {
        public static bool IsCharAllowed(char i)
        {
            return i == ' '
                // 英文
                || (i >= 'A' && i <= 'Z')
                || (i >= 'a' && i <= 'z')
                // 数字
                || (i >= '0' && i <= '9')
                // Latin-1 补充区（带重音的西欧字母等）
                || (i >= 'À' && i <= 'ÿ')
                // 西里尔字母
                || (i >= 'Ѐ' && i <= 'џ')
                // 韩文兼容字母（辅音字母）
                || (i >= 'ㄱ' && i <= 'ㆎ')
                // 韩文音节
                || (i >= '가' && i <= '힣')
                // ===== 中文支持 =====
                // CJK 统一汉字（基本区，最常用）
                || (i >= '\u4E00' && i <= '\u9FFF')
                // CJK 扩展 A 区
                || (i >= '\u3400' && i <= '\u4DBF')
                // CJK 兼容汉字
                || (i >= '\uF900' && i <= '\uFAFF')
                // 中文标点：、。《》「」等
                || (i >= '\u3000' && i <= '\u303F')
                // 全角字符：，！？（）等
                || (i >= '\uFF00' && i <= '\uFFEF')
                // 中文间隔号 ·
                || i == '\u00B7';
        }
    }
}