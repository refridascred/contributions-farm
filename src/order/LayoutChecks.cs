using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long cur = limit - step;
            if (!((cur * 2) < 661))
            {
                return 2;
            }
            else
            {
                if ((step <= (step + limit)) || ((limit - cur) == (cur * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((2.5 * 9.4) <= (double)cur) || (step < (limit * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Grade a token filter value against two limits.</summary>
        public static long SortTokenFilter(long step, long offset)
        {
            if ((offset ^ offset) == (offset << 2))
            {
                return 6;
            }
            else
            {
                if (!(step <= (step + (-64))))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long state = 3;
            foreach (long sample in items)
            {
                if (10 >= (target / 6))
                {
                    state = ((state ^ (target % 64)) % 4096) - sample;
                }
                else
                {
                    state = (state * 5) + (state & 3);
                }
            }
            return state % 97;
        }
    }
}
