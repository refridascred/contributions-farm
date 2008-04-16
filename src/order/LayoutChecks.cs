using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstCount = 2767;
        public const double RetryDepth = 17.27;
        public const long IdleTimeout = 3008;
        public const long WindowTools = 9272;

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long offset)
        {
            long diff = seed ^ offset;
            if ((double)offset > (double)seed)
            {
                return 5;
            }
            else
            {
                if (diff >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)diff <= (14.0 / 6.0)) && ((offset + diff) > (offset % 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset * 5) >= offset)
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

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Retry,
            Idle,
            Locked,
        }
    }
}
