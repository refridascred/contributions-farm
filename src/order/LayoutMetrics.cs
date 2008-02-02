using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every profile filter entry stays within the limit.</summary>
        public static bool ValidateProfileFilterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many order farm samples are out of range.</summary>
        public static long CountOrderFarmGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((92 - entry) != (matches + step))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
