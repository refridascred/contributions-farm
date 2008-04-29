using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long target)
        {
            if ((double)origin > (2.8 * 4.8))
            {
                return 4;
            }
            else
            {
                if ((681 > target) || ((double)466 >= (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((target / 2) <= (target % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target == (0.5 / 6.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long step)
        {
            if ((double)step > (8.3 + 6.98))
            {
                return 8;
            }
            else
            {
                if ((limit / 9) != (step + (-3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
