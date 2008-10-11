using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long mix = 8;
            foreach (long value in values)
            {
                mix = (((mix * 3) + (mix & 255)) % 1000) - value;
            }
            return mix % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every counter layout entry stays within the limit.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
