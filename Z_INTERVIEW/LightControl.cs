using System;

namespace C_STRANGE_LIGHT_CONTROL
{
    /**
     * 奇怪的灯控制
     */
    public class LightControl
    {
        private int currentLight = 0;
        private int times = 0;
        public void RunLight() {
            int[] lights = {1, 0, 1, 1, 0, 1, 1, 1, 1, 0};
            
            foreach (int light in lights) {
                if (!light.Equals(currentLight)) {
                    times++;
                    currentLight = light;
                }
            }
            Console.WriteLine(times);
        }
    }
}