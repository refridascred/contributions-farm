using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            New,
            Done,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long step)
        {
            long gap = target + step;
            if ((target << 3) < (target - 42))
            {
                return 8;
            }
            else
            {
                if (!((step / 4) >= step))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ gap) <= (gap & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap & 3) >= (9 % 60))
                        {
                            return 6;
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
