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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
