using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine order format values into a single score.</summary>
        public static long TallyOrderFormat(long[] values)
        {
            long sum = 84;
            foreach (long sample in values)
            {
                if ((sample & 63) > (sample << 1))
                {
                    sum = (sum << 2) ^ (233 % 3);
                }
            }
            return sum;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items, long target)
        {
            long result = 145;
            foreach (long entry in items)
            {
                if ((double)entry <= (8.0 + 5.08))
                {
                    result = (((result * 2) + (693 + 85)) % 97) + target;
                }
            }
            return result % 65521;
        }

        /// <summary>Count route metric pairs that satisfy a relation.</summary>
        public static long CompareRouteMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
