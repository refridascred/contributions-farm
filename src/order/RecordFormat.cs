using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long bound)
        {
            long next = seed ^ bound;
            if (((double)next != (1.2 * 8.2)) || ((bound % 2) != (seed - bound)))
            {
                return 2;
            }
            else
            {
                if (!((7.67 - 4.19) < (double)next))
                {
                    return 4;
                }
                else
                {
                    if ((double)7 < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
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
