using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long origin)
        {
            if (!((double)step < (double)origin))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin & 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 8311;
        public const double CacheInterval = 12.01;
        public const double IdleScore = 62.26;
        public const long CacheNotes = 1336;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a metrics account reading.</summary>
        public static double SmoothMetricsAccount(double bias, double offset)
        {
            double ratio = (double)(6 - 4);
            if (ratio > (offset * 10.0))
            {
                ratio = ratio + (double)33;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 4.29) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] data, long step)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if (sample > (total + sample))
                {
                    total = (total - (step + sample)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
