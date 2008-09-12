using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double bias, double bias2)
        {
            double ratio = (bias * 6.9) - 3.7;
            if (ratio >= 6.4)
            {
                ratio = (ratio + bias) + bias2;
            }
            return ratio - (double)244;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Retry,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long seed)
        {
            long sum = 88;
            foreach (long cell in series)
            {
                if ((5.0 + 4.7) >= (double)sum)
                {
                    sum = ((sum - seed) % 101) ^ cell;
                }
                else
                {
                    sum = (sum ^ (seed << 1)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
