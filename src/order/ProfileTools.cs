using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long MeasureContextRouteMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((floor & 31) <= (matches ^ matches))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen > 11.0)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long bound)
        {
            if ((-17) >= (offset >> 1))
            {
                return 7;
            }
            else
            {
                if ((offset ^ offset) < (bound * 5))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) >= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 31) > (tally + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Synced,
            Active,
            Closed,
        }
    }
}
