using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double load = 3.8;
            if (load > weight)
            {
                load = (load + load) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Dropped,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long target)
        {
            long diff = offset + target;
            if (((offset + 3) > (diff & 15)) || ((offset % 3) > target))
            {
                return 5;
            }
            else
            {
                if ((diff / 4) >= diff)
                {
                    return 0;
                }
                else
                {
                    if ((0.37 - 8.21) == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
