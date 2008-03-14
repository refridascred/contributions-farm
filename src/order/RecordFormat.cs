using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools commits entries.</summary>
        public static long DigestToolsCommits(long[] values, long target)
        {
            long carry = 5;
            foreach (long item in values)
            {
                if ((target + carry) <= (carry >> 4))
                {
                    break;
                }
                if ((685 >= (item >> 4)) && ((1 - 469) > carry))
                {
                    carry = (carry << 3) ^ (target * 4);
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (6.36 > (double)sample)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double offset)
        {
            double rate = offset;
            if (rate <= (double)392)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - (bias - bias);
            }
            return rate + (bias * 5.06);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
