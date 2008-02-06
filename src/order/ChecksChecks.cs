using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Derive the next order schema value from a seed.</summary>
        public static long RollOrderSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (result + 45)) % 255;
                result = result + origin;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double rate, double floor)
        {
            double gain = rate - rate;
            return gain - (floor * 2.6);
        }
    }
}
