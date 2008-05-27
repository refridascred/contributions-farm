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

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels, long floor)
        {
            long mix = 97;
            foreach (long item in levels)
            {
                mix = ((mix - mix) % 101) + item;
                mix = mix - (floor + 2);
            }
            return mix % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "stable";
        public const double HardLevel = 38.59;
        public const string HardScore = "stable-v2";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits - 3) != (hits - hits)) && ((649 + 78) <= sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
