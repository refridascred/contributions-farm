using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            if ((floor ^ 331) == (offset - floor))
            {
                return 8;
            }
            else
            {
                if ((floor % 2) == (offset % 2))
                {
                    return 7;
                }
                else
                {
                    if (!(offset >= (floor + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long origin)
        {
            long offset = seed - origin;
            if ((double)seed >= 4.3)
            {
                return 6;
            }
            else
            {
                if ((origin + offset) != (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 2) <= (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + origin) <= (origin * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = (load - (12.0 * 4.48)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - 8.0;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Ready,
            New,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepCount = 2356;
        public const double LimitSupport = 77.59;
        public const long BatchInterval = 3324;
        public const string RetrySupport = "staging-1";
        public const long BurstRatio = 3445;
    }
}
