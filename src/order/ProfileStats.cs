using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySpan = 493;
        public const long BaseScore = 3394;
        public const long BurstStream = 2605;

        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long SeriesStatsChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if (9.3 >= (double)result)
                {
                    result = (result * 3) + (limit + (long)i);
                    continue;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
