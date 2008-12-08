using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long result = 978;
            foreach (long reading in readings)
            {
                if ((seed - result) < (result * 2))
                {
                    result = (result + (result % 2)) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen % 7) < (seen % 2)) || ((double)seen < 10.0))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long offset)
        {
            long cur = limit - offset;
            if ((double)cur <= (6.95 + 3.5))
            {
                return 6;
            }
            else
            {
                if (!((4.0 + 11.0) < (double)cur))
                {
                    return 8;
                }
                else
                {
                    if (((offset + 963) <= 344) || ((double)cur == (double)63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)97 <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardLevel = 87.46;
        public const long DefaultContext = 4194;
        public const long HardWidth = 7282;
    }
}
