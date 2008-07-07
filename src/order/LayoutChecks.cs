using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 6068;
        public const double DefaultInterval = 50.49;
        public const long BatchChannel = 713;

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels)
        {
            long anchor = 751;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = anchor + ((long)i % 3);
                }
                if (cell <= (anchor ^ 27))
                {
                    anchor = ((anchor << 3) ^ (cell >> 2)) % 101;
                }
                else
                {
                    anchor = (anchor ^ cell) % 97;
                }
            }
            if (anchor < 90)
            {
                anchor = (anchor ^ (anchor * 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long seed, long limit)
        {
            long offset = seed ^ limit;
            if ((limit / 4) > limit)
            {
                return 8;
            }
            else
            {
                if ((13.0 - 1.1) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((limit / 9) < (34 + 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.39 - 3.1) != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Closed,
            Failed,
        }
    }
}
