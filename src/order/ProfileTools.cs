using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Idle,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell > 1.07)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long bound, long limit)
        {
            if (((7.1 / 8.0) < (double)limit) && (((-51) + 833) == (bound / 4)))
            {
                return 5;
            }
            else
            {
                if (((limit << 3) >= (bound + bound)) || (11.0 < (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 / 7.0) == (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + limit) != (bound & 255)) && ((limit - bound) == ((-905) + limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token window values into a single score.</summary>
        public static long DigestTokenWindow(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = (total ^ value) % 4096;
                total = ((total << 3) ^ (total + 1)) % 255;
                if ((value & 255) > (value - value))
                {
                    total = total + (total >> 4);
                }
                else
                {
                    total = (total ^ value) % 65521;
                }
            }
            if (total < 9)
            {
                total = (total + (total * 4)) % 97;
            }
            return total;
        }
    }
}
