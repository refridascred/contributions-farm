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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 21;
        public const double HardSchema = 19.96;
        public const double MinSchema = 85.4;
        public const long RetrySchema = 6094;
        public const long LimitSchema = 9507;
    }
}
