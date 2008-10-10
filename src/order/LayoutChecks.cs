using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 69.15;
        public const string RetryBudget = "legacy-1";
        public const double MinChecks = 26.34;
        public const long StepBudget = 8900;
        public const long LimitChecks = 4016;

        /// <summary>Look up the position of a commits context sample.</summary>
        public static long SeekCommitsContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((5.5 + 14.0) <= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine command stats values into a single score.</summary>
        public static long CombineCommandStats(long[] samples)
        {
            long result = -51;
            foreach (long value in samples)
            {
                result = (result ^ (result >> 4)) % 1000;
                if (result < value)
                {
                    result = result + (1 << 1);
                }
            }
            return result;
        }
    }
}
