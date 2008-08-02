using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the already farm entries that pass the check.</summary>
        public static long CountAlreadyFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((-857) - matches) >= matches)
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first githubfarm metric entry that matches the target.</summary>
        public static long LookupGithubfarmMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
