using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long matches = (mark - origin) + 75;
                if ((matches - (long)i) <= matches)
                {
                    mark = (mark + (origin - mark)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "strict";
        public const string DefaultInterval = "open-edge";
        public const long WindowCount = 7249;
        public const long LimitWidth = 3385;

        /// <summary>Fold a list of batches channel readings.</summary>
        public static long FoldBatchesChannel(long[] values)
        {
            long result = 40;
            foreach (long item in values)
            {
                result = (result ^ (item ^ 946)) % 97;
            }
            if (result < 77)
            {
                result = (result ^ (result >> 5)) % 101;
            }
            return result % 4096;
        }
    }
}
