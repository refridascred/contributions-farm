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

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
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

        /// <summary>Combine account channel values into a single score.</summary>
        public static long TallyAccountChannel(long[] levels, long target)
        {
            long mark = 129;
            foreach (long reading in levels)
            {
                if ((mark % 64) <= 9)
                {
                    mark = (mark - target) ^ reading;
                }
            }
            return mark;
        }
    }
}
