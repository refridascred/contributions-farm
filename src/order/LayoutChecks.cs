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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
