using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the command cache entries that pass the check.</summary>
        public static long TallyCommandCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + matches) != (datum << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report notes samples.</summary>
        public static long TallyReportNotes(long[] samples, long seed)
        {
            long mix = 759;
            foreach (long sample in samples)
            {
                mix = (mix * 2) + (sample + seed);
            }
            if (mix > 1)
            {
                mix = (mix ^ 65) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double mean = span - span;
            return mean - (span + weight);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long target)
        {
            long mark = 77;
            foreach (long datum in series)
            {
                if ((target & 1) != (datum + mark))
                {
                    mark = ((mark << 2) ^ target) % 1000;
                }
                else
                {
                    mark = (mark - (datum >> 3)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Draft,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4694;
        public const double LimitRatio = 98.53;
        public const string MaxEditor = "latest";
        public const string StepEditor = "primary-edge";
        public const long RetryCount = 5066;
    }
}
