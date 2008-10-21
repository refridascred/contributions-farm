using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2994;
        public const string RetryStream = "open-v2";
        public const long HardInterval = 6723;
        public const long MinFactor = 8600;
        public const long HardTimeout = 2412;

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double mean = (offset - rate) + offset;
            if (mean > rate)
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + (mean - 0.2);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean * 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Stale,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long seed)
        {
            if ((limit << 3) < (limit >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed >> 5) >= seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every session editor entry stays within the limit.</summary>
        public static bool VerifySessionEditorBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
