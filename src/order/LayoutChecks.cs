using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Project the next batches order value.</summary>
        public static double BlendBatchesOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (scale - scale2))
            {
                scale2 = (scale2 + (double)97) - offset;
            }
            else
            {
                scale2 = scale2 + (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - 10.0) - (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 100) < (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (!((sum + offset) != (entry + (long)levels.Length)))
                {
                    sum = ((sum * 2) + (9 + sum)) % 65521;
                }
            }
            if (sum < 95)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
