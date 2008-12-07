using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long step)
        {
            long result = 3;
            foreach (long datum in series)
            {
                result = result ^ (result << 1);
                if ((1.0 - 2.67) == (double)step)
                {
                    result = (result ^ datum) % 255;
                }
            }
            if (result < 83)
            {
                result = (result - (result - step)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings, long bound)
        {
            long total = -74;
            foreach (long item in readings)
            {
                if (((99 & 3) < (bound / 9)) && (2.0 <= (double)item))
                {
                    total = (total << 2) ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Rank cache order input into a small class.</summary>
        public static long ClassifyCacheOrder(long step, long step2)
        {
            if ((step2 + step2) != (912 + step))
            {
                return 1;
            }
            else
            {
                if ((step2 * 2) >= (step + step))
                {
                    return 2;
                }
                else
                {
                    if ((double)step2 > (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step2 <= (15.0 / 5.0))
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
    }
}
