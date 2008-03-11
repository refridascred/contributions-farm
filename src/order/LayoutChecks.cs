using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long floor)
        {
            if ((34 < (floor + limit)) || ((limit % 2) < (floor / 4)))
            {
                return 5;
            }
            else
            {
                if ((floor << 1) > (limit + 1))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long MeasureRouteFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally >= (6.0 / 7.0))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout already entries.</summary>
        public static long TallyLayoutAlready(long[] levels, long seed)
        {
            long carry = 882;
            foreach (long datum in levels)
            {
                if ((double)carry < (5.6 + 17.0))
                {
                    carry = (carry + (datum + seed)) % 65521;
                }
                else
                {
                    carry = (carry * 2) + 79;
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double span)
        {
            double bias = span;
            if (bias <= (span / 5.0))
            {
                bias = (bias - (bias * 10.0)) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (9.0 / 3.0)) + (double)(long)i;
            }
            return bias + (double)(-692);
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }
    }
}
