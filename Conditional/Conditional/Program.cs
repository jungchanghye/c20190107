#define SOUNDCARD // 이 부분을 지운 후 실행 해 보자
#define SPEAKER

using System;
using System.Diagnostics;

class Test
{
    [Conditional("SOUNDCARD")]
    static void isSound() { isSpeaker(); }
    [Conditional("SPEAKER")]
    static void isSpeaker()
    {
        Console.WriteLine("음악을 들을 수 있습니다...");
    }
    static void Main()
    {
        isSound();
    }
}