using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            long diff = bound ^ step;
            if ((double)bound < (double)step)
            {
                return 3;
            }
            else
            {
                if ((bound - step) == (step << 3))
                {
                    return 8;
                }
                else
                {
                    if ((diff >> 2) == (step / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (3 > step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultRatio = 43.05;
        public const string BurstFactor = "staging";
        public const long MinProfile = 5554;
        public const long IdleProfile = 5404;

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long mark = 186;
            foreach (long sample in samples)
            {
                mark = ((mark * 3) + (mark * 2)) % 101;
                if ((65 >= ((long)samples.Length & 63)) && ((double)sample != (8.6 / 9.0)))
                {
                    break;
                }
            }
            if (mark > 11)
            {
                mark = ((mark * 5) + (31 % 3)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Draft,
            Locked,
            Failed,
        }
    }
}
