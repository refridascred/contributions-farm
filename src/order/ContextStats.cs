using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (0 < (cell / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1454;
        public const long DefaultChecks = 1302;
        public const long BaseChecks = 488;
        public const long BurstChecks = 814;
        public const long MinChecks = 5696;
    }
}
