using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank context cluster input into a small class.</summary>
        public static long BucketContextCluster(long step, long seed)
        {
            if (seed > (step ^ 637))
            {
                return 8;
            }
            else
            {
                if ((seed & 31) < (step << 3))
                {
                    return 6;
                }
                else
                {
                    if (((seed - 293) <= (step ^ step)) && ((double)seed >= 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (step ^ 42))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next entry channel value.</summary>
        public static double BlendEntryChannel(double bias, double span)
        {
            double drift = span;
            return (drift - drift) + bias;
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long BucketProfileEntry(long floor, long limit)
        {
            if ((double)limit > (double)122)
            {
                return 6;
            }
            else
            {
                if (((589 % 7) > (floor / 6)) && ((limit % 24) >= limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (13.0 - 0.09))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
