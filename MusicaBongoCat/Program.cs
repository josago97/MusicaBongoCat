using System.Diagnostics;
using WindowsInput;

namespace MusicaBongoCat;

class Program
{
    const int BEATS = 20;
    static InputSimulator inputSimulator;

    static async Task Main()
    {
        Process.Start(new ProcessStartInfo { FileName = "autodestroy.html", UseShellExecute = true });
        Process.Start(new ProcessStartInfo { FileName = "https://bongo.cat", UseShellExecute = true });
        Thread.Sleep(2000);
        inputSimulator = new InputSimulator();

        await PlaySongAsync();
    }

    static async Task PlaySongAsync()
    {
        await Task.WhenAll(new[] { PlayMelodyAsync() });
    }

    static async Task PlayMelodyAsync()
    {
        await Task.Yield();

        //Compas 1
        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_7, 3);
        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        //Compas 5
        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_3, 3);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_7, 3);
        Play(VirtualKeyCode.VK_5, 3);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_0, 1);

        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        //Compas 10
        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 2);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_0, 1);
        Play(VirtualKeyCode.VK_7, 5);

        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 6);

        //Compas 15
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 5);

        Wait(1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 3);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_0, 1);

        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 2);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 2);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_5, 2);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        //Compas 20
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_3, 1);
        Play(VirtualKeyCode.VK_5, 1);
        Play(VirtualKeyCode.VK_7, 1);
        Play(VirtualKeyCode.VK_8, 1);
        Play(VirtualKeyCode.VK_7, 1);

        Play(VirtualKeyCode.VK_3, 12);
    }

    static async Task PlayBassAsync()
    {
        await Task.Yield();

        for (int i = 0; i < BEATS * 2; i++)
        {
            Play(VirtualKeyCode.VK_A, 2.25);
            Play(VirtualKeyCode.VK_D, 0.75);
            Play(VirtualKeyCode.VK_A, 1.5);
            Play(VirtualKeyCode.VK_D, 1.5);
        }
    }

    static void Play(VirtualKeyCode key, double ticks)
    {
        double halfTicks = ticks / 2;

        inputSimulator.Keyboard.KeyDown(key);
        Wait(halfTicks);
        inputSimulator.Keyboard.KeyUp(key);
        Wait(halfTicks);
    }

    static void Wait(double ticks)
    {
        Thread.Sleep((int)(300 * ticks));
    }
}