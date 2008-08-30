using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix ^ (mix * 5)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every record context entry stays within the limit.</summary>
        public static bool ValidateRecordContextBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 7567;
        public const string HardSize = "alpha-v2";
        public const double MaxTimeout = 61.63;
        public const long DefaultGithubfarm = 8299;
        public const long RetryInterval = 6088;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= 2)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
