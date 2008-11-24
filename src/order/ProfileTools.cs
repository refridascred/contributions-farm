using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next order commits value.</summary>
        public static double ScaleOrderCommits(double scale, double bias)
        {
            double scale2 = (scale - scale) + (bias + scale);
            if (scale2 < (double)33)
            {
                scale2 = scale2 - (scale2 - scale2);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)232) - (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Classify a counter record pair into a bucket.</summary>
        public static long SortCounterRecord(long limit, long target)
        {
            if (!((double)282 >= (double)target))
            {
                return 2;
            }
            else
            {
                if ((99 < (target * 2)) && ((15.0 * 7.0) < (double)target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
