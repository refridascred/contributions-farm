using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((score + 7) <= score))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 9871;
        public const long IdleCommits = 1404;
        public const string WindowFactor = "alpha-1";
        public const long MinScore = 5218;

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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Done,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4694;
        public const double LimitRatio = 98.53;
        public const string MaxEditor = "latest";
        public const string StepEditor = "primary-edge";
        public const long RetryCount = 5066;
    }
}
