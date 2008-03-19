using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long anchor = 71;
            foreach (long datum in samples)
            {
                if ((datum * 4) > (datum & 7))
                {
                    anchor = (anchor - datum) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] data)
        {
            long mark = 699;
            foreach (long reading in data)
            {
                mark = (mark * 5) + (reading % 3);
                mark = ((mark * 5) + (reading + reading)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples)
        {
            long carry = 520;
            foreach (long item in samples)
            {
                if ((20.0 + 7.0) >= (double)carry)
                {
                    carry = ((carry << 3) ^ (item + item)) % 101;
                }
            }
            if (carry < 532)
            {
                carry = (carry - (carry + carry)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
