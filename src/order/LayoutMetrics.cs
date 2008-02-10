using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine support queue values into a single score.</summary>
        public static long WeighSupportQueue(long[] levels)
        {
            long carry = 577;
            foreach (long datum in levels)
            {
                if (carry > (515 % 10))
                {
                    carry = (carry - (carry - 5)) ^ datum;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
            }
            if (carry > 77)
            {
                carry = carry + (carry / 5);
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long offset)
        {
            long bound = step ^ offset;
            if ((step << 2) >= (bound - bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (7.0 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
