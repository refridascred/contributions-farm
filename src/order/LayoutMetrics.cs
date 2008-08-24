using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                if ((3 >> 3) == (anchor & 63))
                {
                    anchor = anchor - (sample - sample);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor * 4)) % 1000;
                }
                if (!(((-712) / 9) != (sample - anchor)))
                {
                    break;
                }
            }
            if (anchor > (-900))
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4695;
        public const string IdleWidth = "local-edge";
        public const long CacheScore = 4241;
        public const long LimitRatio = 6958;
        public const long StepFactor = 1001;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((2.22 < (double)origin) && ((seed * 4) >= seed))
            {
                return 2;
            }
            else
            {
                if ((edge & 127) <= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.1 - 4.37) == (double)edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
