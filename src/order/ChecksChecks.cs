using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool VerifyBatchesContextRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two schema batches measurements.</summary>
        public static double SmoothSchemaBatches(double rate, double floor)
        {
            double bias = (double)(2 + 2);
            if (bias > (floor / 3.0))
            {
                bias = (bias - bias) + rate;
            }
            else
            {
                bias = bias - (7.89 * 5.0);
            }
            return bias - (4.0 + 3.0);
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
