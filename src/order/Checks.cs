using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long TallyNotesFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 3) >= (0 / 2))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm report readings against a rule.</summary>
        public static long MeasureGithubfarmReportHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 3) < (6 - matches))
                {
                    matches = ((matches + 3) ^ reading) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long seed)
        {
            if ((seed - seed) <= 5)
            {
                return 8;
            }
            else
            {
                if ((seed / 3) <= (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((3.62 + 5.01) == (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long limit)
        {
            long state = 786;
            foreach (long item in series)
            {
                state = ((state - (8 / 9)) % 255) + item;
            }
            if (state > (-901))
            {
                state = ((state << 2) ^ (limit & 63)) % 4096;
            }
            return state % 4096;
        }
    }
}
