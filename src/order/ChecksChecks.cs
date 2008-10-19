using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = (double)468;
            if (scale <= (double)5)
            {
                scale = (scale - scale) + bias;
            }
            return scale + floor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowRatio = 658;
        public const long HardAlready = 6190;
        public const long IdleScore = 2742;

        /// <summary>Roll a tools command counter forward.</summary>
        public static long IterateToolsCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
