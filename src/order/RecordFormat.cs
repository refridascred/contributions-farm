using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit report context readings against a rule.</summary>
        public static long AuditReportContextOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((9.0 * 20.0) != (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 3372;
        public const long IdleBudget = 3124;
        public const long StepSize = 2777;
        public const long StepFactor = 9537;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long limit)
        {
            long score = 4;
            foreach (long value in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (1 << 3)) % 101) ^ (long)i;
                }
                score = ((score * 4) + value) % 255;
            }
            if (score < 71)
            {
                score = (score + (limit >> 5)) % 101;
            }
            return score;
        }

        /// <summary>Derive the next stream profile value from a seed.</summary>
        public static long IterateStreamProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Idle,
            Queued,
        }
    }
}
