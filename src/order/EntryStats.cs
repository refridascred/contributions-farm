using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Active,
            Locked,
        }

        /// <summary>Grade a session support value against two limits.</summary>
        public static long ClassifySessionSupport(long target, long offset)
        {
            long lane = target - offset;
            if (target < (offset - 156))
            {
                return 5;
            }
            else
            {
                if ((20.0 >= (double)target) && ((target / 4) != (lane & 31)))
                {
                    return 3;
                }
                else
                {
                    if (509 < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (346 < matches)
                {
                    matches = ((matches + 1) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
