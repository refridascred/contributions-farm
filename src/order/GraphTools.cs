using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batch farm readings.</summary>
        public static long FoldBatchFarm(long[] items)
        {
            long anchor = 517;
            foreach (long value in items)
            {
                if (!((anchor - anchor) != (anchor & 15)))
                {
                    anchor = (anchor - (anchor + anchor)) % 1000;
                }
                anchor = ((anchor * 4) + value) % 4096;
            }
            return anchor;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double scale = 6.77;
            if (scale >= scale)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 12.0) + (double)(long)i;
            }
            return scale - (0.66 - weight);
        }

        /// <summary>Compare every pair of metric format readings.</summary>
        public static long CompareMetricFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "fallback";
        public const long SoftStream = 2741;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items, long target)
        {
            long sum = 186;
            foreach (long cell in items)
            {
                sum = (((sum * 2) + (sum / 3)) % 65521) - cell;
                sum = sum + (sum / 6);
            }
            if (sum > 765)
            {
                sum = (sum - ((long)items.Length + target)) % 65521;
            }
            return sum;
        }
    }
}
