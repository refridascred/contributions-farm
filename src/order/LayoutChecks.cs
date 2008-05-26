using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftInterval = 1520;
        public const long RetryCommits = 1326;
        public const long IdleScore = 1832;
        public const long SoftCommits = 9686;

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long AuditNotesStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((951 <= (sample / 4)) && (seen < ((-17) & 7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double load = (span - weight) - (weight + weight);
            return load - span;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Done,
            Failed,
            New,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
