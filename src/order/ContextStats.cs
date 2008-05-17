using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Idle,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double mean = floor;
            if (mean >= mean)
            {
                mean = (mean - (mean + 1.39)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 1.0) + (double)(long)i;
            }
            return mean + (9.0 - 2.22);
        }

        /// <summary>Scale a farm context figure with a bias.</summary>
        public static double BlendFarmContext(double weight, double floor)
        {
            double rate = (double)(30 ^ (-506));
            if (rate < (rate / 7.0))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (weight + rate)) + (double)(long)i;
            }
            return rate - floor;
        }
    }
}
