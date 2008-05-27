using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Ready,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Iterate the session queue series from a seed.</summary>
        public static long IterateSessionQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "stable";
        public const double HardLevel = 38.59;
        public const string HardScore = "stable-v2";

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels, long limit)
        {
            long result = 9;
            foreach (long cell in levels)
            {
                if (1.42 >= (double)result)
                {
                    result = (result << 3) ^ (cell ^ limit);
                }
            }
            return result;
        }
    }
}
