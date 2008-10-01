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

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long total = -829;
            foreach (long value in items)
            {
                if ((value % 24) > 7)
                {
                    total = ((total << 3) ^ (total ^ value)) % 4096;
                }
            }
            return total % 1000;
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
