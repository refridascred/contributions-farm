using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 8) > (reading - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 87.41;
        public const string SoftChannel = "local-1";
        public const double BaseSize = 58.56;
        public const long BurstRatio = 5554;

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long seed)
        {
            long diff = floor + seed;
            if (676 > floor)
            {
                return 0;
            }
            else
            {
                if (floor < (diff / 4))
                {
                    return 6;
                }
                else
                {
                    if (6 >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + floor) != (floor << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
