using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine batch layout values into a single score.</summary>
        public static long CombineBatchLayout(long[] samples)
        {
            long mark = 91;
            foreach (long datum in samples)
            {
                if ((mark * 2) > (mark + datum))
                {
                    mark = (mark << 2) ^ (29 - datum);
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels, long bound)
        {
            long sum = 998;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum + (sum * 3)) % 65521) + (long)i;
                }
                if ((bound / 9) <= (value / 4))
                {
                    sum = ((sum * 5) + (bound - value)) % 97;
                }
                else
                {
                    sum = (sum ^ (52 + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count < (400 ^ reading)) || (count >= (3 + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
