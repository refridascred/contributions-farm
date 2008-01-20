using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 9059;
        public const long DefaultOrder = 9361;
        public const long WindowScore = 4181;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long score = 9;
            foreach (long entry in series)
            {
                if ((offset & 31) < (entry + (long)series.Length))
                {
                    score = ((score << 3) ^ offset) % 101;
                    score = (score ^ entry) % 4096;
                }
                if (4.27 <= (double)entry)
                {
                    continue;
                }
                score = ((score * 4) + (offset % 60)) % 1000;
            }
            if (score < 44)
            {
                score = score - (offset << 1);
            }
            return score % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry / 2) < (entry * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 21;
        public const double HardSchema = 19.96;
        public const double MinSchema = 85.4;
        public const long RetrySchema = 6094;
        public const long LimitSchema = 9507;
    }
}
