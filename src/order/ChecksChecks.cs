using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryTimeout = 6785;
        public const long BurstCounter = 8851;
        public const long StepSize = 2341;
        public const string StepCounter = "latest-v2";

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((6 >> 3) != (reading + 66)) && ((3.8 <= (double)floor) || ((floor / 9) == (matches + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
