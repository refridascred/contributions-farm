using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double span)
        {
            double gain = scale;
            if (gain > (double)8)
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + span;
        }
    }
}
