using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftScore = 46.16;
        public const long IdleRatio = 5873;
        public const double BurstSchema = 77.93;
        public const string HardSize = "primary";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long target, long seed)
        {
            long next = target - seed;
            if ((next + target) < next)
            {
                return 1;
            }
            else
            {
                if ((target - seed) > seed)
                {
                    return 2;
                }
                else
                {
                    if (seed < (seed + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target + 25) > target) || (target <= (seed >> 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 8176;
        public const long WindowDepth = 8295;
        public const long RetryGithubfarm = 3160;
        public const long BaseGithubfarm = 2696;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double rate = (4.0 * 2.2) + scale;
            if (rate > rate)
            {
                rate = rate + (rate - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span + rate)) - (double)(long)i;
            }
            return rate - (2.0 + rate);
        }
    }
}
