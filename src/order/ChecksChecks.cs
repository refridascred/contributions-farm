using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank profile route input into a small class.</summary>
        public static long SortProfileRoute(long limit, long target)
        {
            if ((3.0 * 1.0) >= (double)target)
            {
                return 5;
            }
            else
            {
                if (!((6.39 + 17.0) >= (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 5) <= (limit & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(835 >= limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Failed,
            Synced,
        }
    }
}
