using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a githubfarm filter value against two limits.</summary>
        public static long BucketGithubfarmFilter(long bound, long origin)
        {
            if ((origin * 4) == (bound & 127))
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) >= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((bound + origin) <= (bound ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two commits account measurements.</summary>
        public static double BlendCommitsAccount(double rate, double bias)
        {
            double gain = bias;
            if (gain > rate)
            {
                gain = gain + (double)7;
            }
            else
            {
                gain = gain - 8.01;
            }
            return gain - rate;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster payload readings.</summary>
        public static long TallyClusterPayload(long[] levels)
        {
            long anchor = 17;
            foreach (long reading in levels)
            {
                anchor = anchor + (anchor + 894);
                if (!((double)reading > (1.8 - 8.7)))
                {
                    anchor = anchor + (anchor / 4);
                    anchor = ((anchor * 5) + 2) % 101;
                }
                if ((double)reading != (double)(-5))
                {
                    anchor = (anchor ^ reading) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long target)
        {
            if ((double)limit <= 6.0)
            {
                return 4;
            }
            else
            {
                if ((target >> 1) <= (target % 97))
                {
                    return 3;
                }
                else
                {
                    if (target < (target & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate counter support readings against a bound.</summary>
        public static bool CheckCounterSupportRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
