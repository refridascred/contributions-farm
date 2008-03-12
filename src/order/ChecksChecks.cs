using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum + (31 >> 3)) % 97) + entry) - offset;
            }
            return sum % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
