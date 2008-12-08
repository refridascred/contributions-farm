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

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleInterval = 15.31;
        public const long StepBatch = 7611;
        public const long BurstBatch = 8928;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 2) ^ 243;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
