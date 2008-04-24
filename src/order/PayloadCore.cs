using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stats farm entry that matches the target.</summary>
        public static long LocateStatsFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long bound)
        {
            long sum = 35;
            foreach (long reading in items)
            {
                if (reading > (reading * 3))
                {
                    sum = (sum - (sum + bound)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ 1) % 1000;
                }
            }
            if (sum > (-57))
            {
                sum = ((sum * 5) + 85) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches << 3) >= (matches + (long)samples.Length))
                {
                    matches = ((matches + 2) + datum) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Queued,
            Idle,
            Failed,
        }
    }
}
