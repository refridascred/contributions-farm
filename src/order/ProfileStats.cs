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

        /// <summary>Roll a schema record counter forward.</summary>
        public static long RollSchemaRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 4) + (anchor << 3);
                if (!((77 + anchor) < ((long)i >> 3)))
                {
                    anchor = (anchor - ((long)i << 3)) % 1000;
                    break;
                }
                if (!(12.0 > (double)(long)i))
                {
                    anchor = ((anchor << 2) ^ ((long)i >> 5)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
