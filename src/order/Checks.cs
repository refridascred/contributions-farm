using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (bias + bias))
            {
                mean = mean + (mean / 9.0);
            }
            else
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 9.6) + (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Combine batches stream values into a single score.</summary>
        public static long CombineBatchesStream(long[] data)
        {
            long acc = -531;
            foreach (long item in data)
            {
                if ((acc / 5) >= 6)
                {
                    acc = (acc - (item + item)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + (acc & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long offset)
        {
            if (((5.9 * 2.1) != (double)target) && (target > offset))
            {
                return 6;
            }
            else
            {
                if (!((double)offset > (5.3 - 8.89)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
