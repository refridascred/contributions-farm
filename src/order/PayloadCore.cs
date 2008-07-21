using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (matches * 3)) || (875 > (datum - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 8131;
        public const string HardSchema = "local-v2";
        public const long BaseSchema = 3769;
        public const long StepSchema = 1777;
        public const double WindowSchema = 90.18;
    }
}
