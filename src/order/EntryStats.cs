using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) == (seen / 5)) && ((9 % 97) <= seen))
                {
                    seen = ((seen + 2) - item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long SortTokenPayload(long limit, long floor)
        {
            if ((floor * 2) < (floor + limit))
            {
                return 8;
            }
            else
            {
                if ((floor >> 2) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 1) == (limit & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit % 16) < (0 ^ limit)) || ((limit + floor) >= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long span = step - bound;
            if (!((span - span) <= (step + span)))
            {
                return 8;
            }
            else
            {
                if ((span << 3) <= (step + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)(-3) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span != (14.0 * 3.48))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
