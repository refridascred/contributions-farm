using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long origin)
        {
            long step = seed + origin;
            if (((step >> 5) != (seed % 100)) || ((23 ^ origin) > (origin - step)))
            {
                return 3;
            }
            else
            {
                if ((origin / 6) != (seed & 63))
                {
                    return 8;
                }
                else
                {
                    if (!((step - origin) < (step ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally > (cell / 8)) && ((tally + tally) < cell)) || ((double)cell >= (4.8 / 7.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Active,
            New,
            Closed,
            Paused,
        }

        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long MeasureRouteLayoutMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((3.54 / 5.0) > (double)hits)
                {
                    hits = ((hits + 2) - sample) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
