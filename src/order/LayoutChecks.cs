using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values)
        {
            long anchor = 130;
            foreach (long cell in values)
            {
                anchor = (((anchor * 4) + anchor) % 4096) ^ cell;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long offset)
        {
            long diff = seed ^ offset;
            if ((double)offset > (double)seed)
            {
                return 5;
            }
            else
            {
                if (diff >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)diff <= (14.0 / 6.0)) && ((offset + diff) > (offset % 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset * 5) >= offset)
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
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheSize = 9574;
        public const string HardCommand = "legacy-v2";
        public const long MaxDepth = 258;
        public const long MinCommand = 9284;
        public const long MinDepth = 3377;
    }
}
