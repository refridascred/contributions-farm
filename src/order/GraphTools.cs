using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((step % 5) > 610))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 79.46;
        public const double RetryLevel = 77.61;
        public const double CacheRatio = 5.86;
        public const string StepPayload = "open-edge";

        /// <summary>Scale a window layout figure with a bias.</summary>
        public static double SmoothWindowLayout(double ratio, double offset)
        {
            double rate = (6.4 * 5.4) + (double)763;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (ratio / 9.0)) - (double)(long)i) - offset;
            }
            return rate + (double)1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
