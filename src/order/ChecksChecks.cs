using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long target)
        {
            if ((offset * 3) > 469)
            {
                return 1;
            }
            else
            {
                if ((15.0 / 8.0) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset * 2) != (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset & 127) <= (target * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
