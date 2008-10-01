using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load - (span + 3.0);
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
