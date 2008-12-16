using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (8 >= hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Count the contributi route entries that pass the check.</summary>
        public static long TallyContributiRouteGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 5) == (count + datum))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }
    }
}
