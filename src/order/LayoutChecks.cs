using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchRatio = 65.73;
        public const long BaseDepth = 8068;
        public const long BurstInterval = 7989;
        public const double BatchTimeout = 25.52;
        public const long BurstToken = 3038;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a batch token counter forward.</summary>
        public static long DeriveBatchToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (offset - acc)) % 65521;
                acc = (acc << 3) ^ (offset << 1);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long seed)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                score = (score - (seed * 3)) % 255;
                score = (score - (score + reading)) % 97;
                if ((949 << 2) < reading)
                {
                    score = (score - (seed % 24)) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit schema cache readings against a rule.</summary>
        public static long AuditSchemaCacheMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (23 < tally)
                {
                    tally = ((tally + 2) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
