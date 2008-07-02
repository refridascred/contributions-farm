using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long seed)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 3) ^ (90 - entry)) % 1000) + (long)i;
                }
                anchor = (anchor ^ (9 & 7)) % 255;
                if (anchor <= (820 ^ 76))
                {
                    anchor = (anchor ^ 365) % 97;
                }
            }
            if (anchor > 94)
            {
                anchor = ((anchor << 2) ^ seed) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Locked,
            Idle,
            Retry,
        }
    }
}
