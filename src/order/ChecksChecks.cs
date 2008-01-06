using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
