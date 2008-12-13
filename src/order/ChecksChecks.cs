using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 2) <= 4)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Validate profile record readings against a bound.</summary>
        public static bool ValidateProfileRecordRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
