using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 76.35;
        public const long IdleScore = 3456;
        public const string StepRatio = "stable";
        public const long DefaultFactor = 803;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long floor)
        {
            if ((floor / 4) < offset)
            {
                return 5;
            }
            else
            {
                if (7.5 >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor % 24) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset - offset) > (949 & 31))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long carry = 32;
            foreach (long value in items)
            {
                carry = carry + (value - carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long PairLayoutTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
