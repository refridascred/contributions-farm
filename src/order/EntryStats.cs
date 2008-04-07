using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long floor, long step)
        {
            if (floor >= step)
            {
                return 2;
            }
            else
            {
                if (((floor % 10) != (floor + (-3))) && ((step + step) > (step - step)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((reading / 9) >= (tally >> 1)) || ((tally >> 1) >= (620 ^ (long)levels.Length))) && ((tally + 81) != (500 - 41)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile token entry stays within the limit.</summary>
        public static bool ValidateProfileTokenBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
