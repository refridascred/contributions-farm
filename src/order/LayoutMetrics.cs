using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8010;
        public const string MaxTimeout = "local-edge";
        public const string CacheWindow = "cached";

        /// <summary>Count the layout route entries that pass the check.</summary>
        public static long AuditLayoutRouteMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((origin ^ count) > (origin ^ origin))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm channel readings.</summary>
        public static long PairGithubfarmChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
