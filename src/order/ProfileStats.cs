using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally & 3) <= (seed + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - 88) >= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
