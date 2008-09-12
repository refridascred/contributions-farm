using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long origin)
        {
            long offset = floor + origin;
            if ((double)origin < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((origin - floor) <= (origin ^ origin))
                {
                    return 7;
                }
                else
                {
                    if (((-516) + origin) >= (origin >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + offset) < offset) || ((origin ^ 67) < (floor + 44)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double mean = 11.0 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (((mean - (double)96) + (double)(long)i) + ratio) - bias;
            }
            return mean + (mean * 0.7);
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Synced,
            Paused,
            Locked,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 20.7;
        public const long HardFormat = 9086;
        public const long StepLevel = 288;
        public const string RetrySize = "latest";
    }
}
