using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metric counter value against two limits.</summary>
        public static long SortMetricCounter(long target, long origin)
        {
            long prev = target ^ origin;
            if ((6.0 + 3.88) == (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) > target)
                {
                    return 1;
                }
                else
                {
                    if ((91 + origin) > (origin ^ prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev <= (11.0 + 6.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 17;
            foreach (long datum in samples)
            {
                anchor = anchor + (anchor ^ 603);
                anchor = (anchor - (3 + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Draft,
            Stale,
            Synced,
            New,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double span)
        {
            double load = scale;
            if (load > scale)
            {
                load = (load - 3.55) - span;
            }
            else
            {
                load = load - (9.57 + load);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (double)0;
        }
    }
}
