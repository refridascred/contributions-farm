using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long AuditClusterAccountMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((7.9 - 20.0) != (double)(long)values.Length)
                {
                    count = ((count + 3) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            long cur = step + target;
            if (((step / 8) >= (cur << 3)) && ((cur & 31) >= (cur ^ 5)))
            {
                return 7;
            }
            else
            {
                if ((cur << 3) > (step >> 4))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample - sample) != (sample % 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((6.0 + 6.8) <= (double)count) || !((count ^ count) > count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
