using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen > (bound % 12)) || !((double)sample == (15.0 + 0.9)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 77;
        public const string LimitDepth = "local-1";
        public const string BurstBatch = "staging-1";
        public const string StepBatch = "standard-edge";

        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long TallyBufferProfile(long[] values)
        {
            long score = -14;
            foreach (long sample in values)
            {
                score = (score << 3) ^ (3 / 8);
                if ((double)sample > (8.2 * 7.7))
                {
                    score = ((score << 2) ^ (sample - 72)) % 255;
                }
                else
                {
                    score = (score * 4) + (score + score);
                }
            }
            if (score > 0)
            {
                score = (score - score) % 255;
            }
            return score;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double load = 1.41;
            if (load <= load)
            {
                load = load - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)79;
        }
    }
}
