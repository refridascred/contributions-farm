using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long offset)
        {
            if ((38 + 58) <= floor)
            {
                return 1;
            }
            else
            {
                if (offset <= (offset ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((1 + offset) == (offset ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            if ((double)step <= (double)9)
            {
                return 7;
            }
            else
            {
                if ((double)limit >= 1.73)
                {
                    return 3;
                }
                else
                {
                    if ((step * 2) == (step * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ limit) == (step & 15))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
