using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a channel format figure with a bias.</summary>
        public static double SmoothChannelFormat(double bias, double offset)
        {
            double load = bias;
            if (load > bias)
            {
                load = (load - (bias * 6.0)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (bias * 0.82);
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long AuditEditorMetricsGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (8 >= (origin - origin))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally > (offset - tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count commits report pairs that satisfy a relation.</summary>
        public static long OverlapCommitsReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 8773;
        public const double MinCluster = 72.36;
        public const string CacheScore = "staging-edge";
    }
}
