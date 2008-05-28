using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 7022;
        public const long StepGithubfarm = 8112;
        public const long SoftGithubfarm = 2915;
        public const string CacheGithubfarm = "stable-v2";
        public const long MaxGithubfarm = 9588;

        /// <summary>Count the record notes entries that pass the check.</summary>
        public static long CountRecordNotesMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((bound ^ datum) < (bound >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema editor measurements.</summary>
        public static double ScaleSchemaEditor(double bias, double span)
        {
            double load = bias;
            if (load > (4.15 / 3.0))
            {
                load = (load + load) - span;
            }
            return load + (4.0 / 4.0);
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double load = span;
            return (load - span) + ratio;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum + 9) >= (seen >> 2)) || (((seen ^ seen) <= (-3)) || ((18.0 + 6.9) > (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
