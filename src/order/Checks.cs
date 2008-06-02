using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 2) + mix;
                if ((2.0 * 2.3) >= (double)limit)
                {
                    mix = ((mix * 5) + (mix - limit)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long carry = 43;
            foreach (long datum in series)
            {
                carry = ((carry ^ step) % 1000) + datum;
            }
            if (carry < 724)
            {
                carry = (carry << 2) ^ 367;
            }
            return carry;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Draft,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long bound)
        {
            if ((bound + bound) > bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound < (0.93 * 11.0))
                {
                    return 4;
                }
                else
                {
                    if (((bound - 799) > floor) && ((733 ^ bound) <= 24))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >= (bound * 2)) || (bound >= (floor ^ 43)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry - offset) != (entry + offset)) || ((offset >= (5 - entry)) || ((matches + offset) < (entry % 100))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
