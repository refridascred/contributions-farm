using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long CountBufferContributiOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.9 / 7.0))
                {
                    matches = ((matches + 2) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "fallback-edge";
        public const long StepChannel = 8689;
        public const string SoftBudget = "latest";
        public const long DefaultChannel = 1320;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double rate, double bias)
        {
            double load = rate;
            if (load >= (rate / 8.0))
            {
                load = load - (bias / 3.0);
            }
            else
            {
                load = load + (double)72;
            }
            return load + (rate * 4.7);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging-1";
        public const string BaseFormat = "fallback-1";
        public const double RetryDepth = 26.8;
        public const double BatchFormat = 72.5;

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long mark = 47;
            foreach (long entry in values)
            {
                if ((-1) >= (mark + entry))
                {
                    mark = (mark * 2) + (entry / 2);
                }
                else
                {
                    mark = ((mark << 3) ^ 585) % 97;
                }
            }
            if (mark < 188)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }
    }
}
