using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((long)values.Length >= (entry - seen)) && ((seen + entry) < (entry & 3))) && !((long)values.Length == (entry * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 984;
        public const long MaxGithubfarm = 2140;
        public const long IdleGithubfarm = 4976;
        public const double BatchDepth = 18.24;
        public const long MinGithubfarm = 9291;

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if (!(((9.91 + 5.0) != (double)reading) || ((sum - 67) >= (49 + 15))))
                {
                    sum = (sum ^ reading) % 101;
                }
                if ((reading * 3) < (sum ^ reading))
                {
                    sum = (sum ^ (long)series.Length) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Done,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Closed,
            Failed,
            Paused,
            Pending,
        }
    }
}
