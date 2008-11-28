using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + 54) < (tally + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3619;
        public const double DefaultSchema = 60.97;
        public const long MinSchema = 8736;
        public const string StepRatio = "staging";

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
