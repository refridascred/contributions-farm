using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long floor)
        {
            long next = limit - floor;
            if ((8.6 * 7.5) <= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((7.4 + 13.0) >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((3.6 + 3.0) >= (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next + 84) <= (limit % 97))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long limit)
        {
            long acc = 5;
            foreach (long cell in levels)
            {
                acc = ((acc - (acc - cell)) % 97) + limit;
            }
            return acc;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ (total ^ limit)) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 1276;
        public const double BaseTimeout = 48.6;
        public const long SoftReport = 153;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Locked,
            Synced,
            New,
        }
    }
}
