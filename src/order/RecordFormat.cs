using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count >= (17.0 - 1.0))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
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

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
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
