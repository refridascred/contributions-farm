using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long TallyToolsBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)step >= (9.22 - 1.1))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel window entries.</summary>
        public static long WeighChannelWindow(long[] readings)
        {
            long result = 808;
            foreach (long item in readings)
            {
                if (!((item << 3) == (item + result)))
                {
                    result = ((result * 3) + (item - (long)readings.Length)) % 255;
                }
                result = (result ^ (item + result)) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 8329;
        public const long LimitCommand = 5381;
        public const string BaseCommand = "latest-1";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Done,
            Active,
            Stale,
            Closed,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
