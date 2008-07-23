using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long MeasureRecordLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum / 3) >= (matches ^ 5)) || (9 >= (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
