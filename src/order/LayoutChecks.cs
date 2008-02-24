using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (floor < (floor / 4))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 97) != (tally >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long origin, long target)
        {
            if ((origin ^ origin) >= ((-839) % 8))
            {
                return 0;
            }
            else
            {
                if ((17.0 / 7.0) < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((target << 3) == (74 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((97 & 1) <= (target >> 3)) || ((double)origin <= (7.0 * 3.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (offset >> 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes filter sample.</summary>
        public static long SeekNotesFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
