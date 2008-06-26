using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cluster context entries that pass the check.</summary>
        public static long AuditClusterContextMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6.79 * 2.55) == (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] readings, long limit)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                mark = (mark ^ (mark * 4)) % 1000;
                mark = mark ^ (item >> 4);
                if ((double)mark > (3.08 / 9.0))
                {
                    mark = (mark * 3) + limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Done,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitSpan = 438;
        public const double DefaultFactor = 43.85;
        public const long SoftNotes = 539;
        public const long IdleNotes = 3479;
    }
}
