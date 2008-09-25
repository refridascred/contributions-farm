using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels, long bound)
        {
            long state = -7;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 / 6.0))
                {
                    state = (state ^ bound) % 4096;
                }
            }
            if (state < 42)
            {
                state = (state + (-5)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items, long bound)
        {
            long carry = 79;
            foreach (long datum in items)
            {
                carry = carry + (datum << 2);
                if ((4.96 - 1.88) <= (double)bound)
                {
                    carry = (carry << 2) ^ datum;
                }
                else
                {
                    carry = (carry ^ ((-11) << 2)) % 1000;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (bound - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of entry commits readings.</summary>
        public static long CompareEntryCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
