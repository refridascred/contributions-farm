using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long mix = 546;
            foreach (long entry in values)
            {
                if (entry < mix)
                {
                    mix = (mix + (mix ^ 75)) % 255;
                }
                if ((mix + mix) < (entry + 75))
                {
                    break;
                }
            }
            if (mix < 124)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
