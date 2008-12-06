using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= (double)53)
            {
                bias2 = (bias2 - (5.81 - bias2)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 - (bias2 - weight);
        }

        /// <summary>Fold a list of contributi githubfarm readings.</summary>
        public static long ScoreContributiGithubfarm(long[] levels, long limit)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (((limit - limit) != (7 - limit)) || (limit < 6))
                {
                    mark = ((mark << 2) ^ (limit ^ sample)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Failed,
            New,
            Locked,
            Closed,
        }
    }
}
