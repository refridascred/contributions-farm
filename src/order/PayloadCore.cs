using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a entry stats figure with a bias.</summary>
        public static double AdjustEntryStats(double gain, double bias)
        {
            double bias2 = gain + gain;
            return (bias2 - 8.5) + bias;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
