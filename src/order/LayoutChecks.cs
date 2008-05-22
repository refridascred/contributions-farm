using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first metric batches entry that matches the target.</summary>
        public static long SeekMetricBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long step)
        {
            if ((double)step <= (7.23 * 3.56))
            {
                return 7;
            }
            else
            {
                if ((step + 78) >= (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) == (step ^ 84))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step * 5) <= (step % 100)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Closed,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((double)8 >= (double)bound) || ((double)(long)i != (1.0 + 9.2)))
                {
                    state = (state ^ ((long)i + state)) % 255;
                    break;
                }
                else
                {
                    state = state + (state << 2);
                }
                state = (state - bound) % 1000;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((8.0 - 2.5) > (double)seen)
                {
                    seen = ((seen + 2) ^ reading) - origin;
                }
            }
            return seen;
        }
    }
}
