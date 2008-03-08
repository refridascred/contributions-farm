using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of report entry readings.</summary>
        public static long ScoreReportEntry(long[] data, long limit)
        {
            long acc = 48;
            foreach (long item in data)
            {
                if ((item * 2) > (limit + item))
                {
                    acc = (acc + (55 >> 3)) % 1000;
                }
                else
                {
                    acc = acc + (limit + limit);
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values, long bound)
        {
            long mix = 503;
            foreach (long entry in values)
            {
                if (mix <= (bound + mix))
                {
                    mix = ((mix + (bound + bound)) % 97) ^ entry;
                }
            }
            return mix;
        }

        /// <summary>Derive the next metric account value from a seed.</summary>
        public static long StepMetricAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ 848) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}
