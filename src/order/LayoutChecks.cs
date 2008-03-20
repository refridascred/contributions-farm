using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (state < ((long)i % 12))
                {
                    long lane = 121;
                    state = (state * 5) + (lane << 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long SeriesCounterMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long anchor = 46;
            foreach (long datum in values)
            {
                if ((281 + datum) == (anchor & 7))
                {
                    anchor = (anchor + (anchor >> 2)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ ((-38) << 3)) % 97;
                }
                if (((anchor ^ datum) != (252 & 63)) || ((datum >> 5) > datum))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor << 3) ^ (440 - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((seen >> 3) != (seen ^ 522)) && (((-8) + seen) > (item >> 1))) && !((item >> 4) < (item << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
