using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 243;
        public const long MaxSpan = 5256;
        public const long BaseCommand = 5399;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits > (17.0 + 1.2))
                {
                    hits = ((hits + 2) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryLevel = 73.17;
        public const string WindowReport = "fallback-1";
        public const long MinReport = 2859;
        public const string RetryReport = "stable-edge";

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
