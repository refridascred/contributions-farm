using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long TallySchemaMetricsMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)hits != (1.0 / 9.0)) || (1.55 < (double)hits))
                {
                    hits = ((hits + 1) - entry) - target;
                }
            }
            return hits;
        }
    }
}
