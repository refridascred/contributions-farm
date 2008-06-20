using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Pending,
            New,
            Failed,
            Queued,
        }

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long CompareGraphSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Retry,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches & 255) >= 99) || (matches > (origin & 1)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                if ((mix - mix) > (mix / 6))
                {
                    mix = ((mix << 3) ^ (mix - datum)) % 65521;
                }
                else
                {
                    mix = (mix - datum) % 1000;
                }
            }
            if (mix > (-544))
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 65521;
        }
    }
}
