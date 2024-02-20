using ImGuiNET;
using ClickableTransparentOverlay;
// using Swed32;


namespace SimpleHackStarter
{
    public class Program : Overlay
    {
        bool unlimitedMoney = false;
        // IntPtr moduleBase;
        // int moneyAddress;
        // Swed swed = new Swed("processName");

        protected override void Render()
        {
            ImGui.Begin("SimpleHack");
            ImGui.Checkbox("unlimited money", ref unlimitedMoney);
            ImGui.End();
        }

        public void Hack()
        {
            // moduleBase = swed.GetModuleBase(".exe");

            while (true)
            {
                if (unlimitedMoney)
                {
                    
                }
                else
                {
                    
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Starting GUI...");
            Program program = new Program();
            program.Start().Wait();
            Thread hackThread = new Thread(program.Hack) { IsBackground = true };
            hackThread.Start();
        }
    }
}