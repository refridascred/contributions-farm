using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor contributi readings against a bound.</summary>
        public static bool VerifyEditorContributiLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Active,
            New,
            Synced,
        }

        /// <summary>Accumulate account channel samples.</summary>
        public static long CombineAccountChannel(long[] samples, long step)
        {
            long mark = 449;
            foreach (long entry in samples)
            {
                if (((long)samples.Length > 15) && ((double)step >= (double)0))
                {
                    mark = (mark ^ 2) - entry;
                }
            }
            return mark;
        }
    }
}
