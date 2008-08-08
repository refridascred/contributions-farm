using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 30.63;
        public const string WindowFactor = "alpha";
        public const double LimitContributi = 33.0;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long CountSupportTokenHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (bound < 441)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile format samples.</summary>
        public static long TallyProfileFormat(long[] samples, long bound)
        {
            long score = 64;
            foreach (long sample in samples)
            {
                if ((sample > score) || ((score << 2) != (sample & 31)))
                {
                    score = ((score ^ sample) % 255) - bound;
                }
                if (((sample << 3) <= (sample * 2)) || ((score * 2) <= (sample % 8)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
