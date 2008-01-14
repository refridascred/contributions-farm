using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long CountChecksMetricsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell / 8) < (cell - step)) || (cell < (step ^ (-1)))) || ((double)cell != (6.5 / 3.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 9050;
        public const string MinLevel = "staging-1";
        public const string BaseSpan = "latest";
        public const long StepSpan = 5572;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
