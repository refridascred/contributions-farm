using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long bound)
        {
            if ((double)bound > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((bound >> 2) < (383 + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (4.0 - 2.79))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
