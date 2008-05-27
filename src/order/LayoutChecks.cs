using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Idle,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (1.3 * 16.0)) || ((double)sample < (0.24 / 4.0)))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((long)values.Length > ((long)values.Length << 1))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
