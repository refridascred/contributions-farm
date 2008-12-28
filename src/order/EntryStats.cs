using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) >= (tally + item))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count < (370 % 10)) && (count > (count ^ sample))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long target)
        {
            long edge = origin ^ target;
            if ((target >= origin) || (1 <= (origin + edge)))
            {
                return 4;
            }
            else
            {
                if (origin >= (edge - target))
                {
                    return 2;
                }
                else
                {
                    if ((edge >= (988 + origin)) && ((double)edge == (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin * 5) == (edge / 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (((4.5 - 1.44) != (double)floor2) && (next > (next + floor2)))
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor2) < 30)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < (9.16 * 5.65))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor2 > next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
