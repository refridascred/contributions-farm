using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up order support samples.</summary>
        public static long OverlapOrderSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long CombineMetricsCluster(long[] series)
        {
            long acc = 4;
            foreach (long entry in series)
            {
                acc = (acc ^ entry) % 97;
                acc = acc + (acc % 97);
                acc = (acc ^ (acc & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long offset)
        {
            if (((limit & 31) != (limit << 1)) || (offset < (0 << 1)))
            {
                return 3;
            }
            else
            {
                if ((18.0 / 6.0) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell >> 4) > (step * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3581;
        public const long SoftInterval = 5339;
        public const double MaxRatio = 77.79;
    }
}
