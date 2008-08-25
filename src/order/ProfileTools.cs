using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((9.6 - 8.69) < (double)step)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinInterval = 7728;
        public const long RetryTimeout = 5896;
        public const long SoftDepth = 1153;
        public const long RetryRoute = 4393;
    }
}
