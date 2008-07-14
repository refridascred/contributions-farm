using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if (step > (step + bound))
            {
                return 0;
            }
            else
            {
                if ((bound <= (step / 2)) || ((step & 255) >= step))
                {
                    return 2;
                }
                else
                {
                    if ((228 * 2) >= (56 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Active,
            New,
            Failed,
            Draft,
        }
    }
}
