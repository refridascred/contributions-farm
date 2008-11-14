using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff >> 1) <= (seed + 99))
            {
                return 0;
            }
            else
            {
                if ((limit + diff) != (limit * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 7) == (entry * 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ ((long)i - step)) % 255;
                if ((step & 1) >= result)
                {
                    break;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 65521;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if ((((long)series.Length - (long)series.Length) < (total - total)) || ((total - total) != ((-3) ^ sample)))
                {
                    total = total - (sample * 2);
                }
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
