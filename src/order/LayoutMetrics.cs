using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a batch command reading.</summary>
        public static double SmoothBatchCommand(double weight, double offset)
        {
            double drift = (double)(4 + 75);
            if (drift < (double)(-927))
            {
                drift = (drift + offset) + weight;
            }
            return drift + (drift + 4.4);
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
