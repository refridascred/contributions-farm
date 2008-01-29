using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 51.06;
        public const long HardScore = 7914;
        public const double DefaultMetric = 0.78;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (-75)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long state = 70;
            foreach (long value in series)
            {
                if (((long)series.Length << 1) >= state)
                {
                    state = ((state * 5) + (state >> 4)) + value;
                }
            }
            if (state < (-10))
            {
                state = (state * 5) + ((-876) - state);
            }
            return state % 4096;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((611 - bound) <= bound)
                {
                    score = (score - (score & 3)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (long)i) % 101;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
