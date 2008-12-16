using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((20.0 + 8.8) <= (double)target)
                {
                    acc = (acc + (long)i) % 1000;
                    break;
                }
                acc = ((acc << 3) ^ ((long)i + 6)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSpan = 50.92;
        public const long LimitBudget = 7623;
        public const long StepSchema = 1028;
        public const string MaxDepth = "strict-edge";
        public const double IdleCount = 28.31;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
