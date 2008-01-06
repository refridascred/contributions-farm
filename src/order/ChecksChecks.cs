using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items, long target)
        {
            long total = 9;
            foreach (long cell in items)
            {
                if ((total + total) > target)
                {
                    total = (total + (total % 64)) - cell;
                }
            }
            if (total > 7)
            {
                total = ((total * 5) + ((-8) / 3)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
