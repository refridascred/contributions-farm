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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long step)
        {
            if ((step - 82) < (943 / 4))
            {
                return 1;
            }
            else
            {
                if ((step * 2) < (59 + step))
                {
                    return 5;
                }
                else
                {
                    if (!((3 << 1) == (origin % 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
