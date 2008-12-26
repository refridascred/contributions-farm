using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((seen % 10) > sample) || (seen < (301 >> 5))))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 73.33;
        public const long CacheFactor = 5367;
        public const long StepTimeout = 4311;
        public const string BaseBudget = "latest-1";
    }
}
