using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items, long target)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor * 4) + item) % 97;
                if ((double)item >= (7.94 + 5.0))
                {
                    anchor = anchor ^ ((long)items.Length - target);
                }
            }
            return anchor;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc * 4) + ((long)i * 4)) - (long)i2;
                }
                acc = (acc + bound) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings)
        {
            long sum = 635;
            foreach (long reading in readings)
            {
                sum = (sum << 3) ^ (5 ^ (-20));
                sum = (sum - (reading + 3)) % 4096;
            }
            return sum % 1000;
        }
    }
}
