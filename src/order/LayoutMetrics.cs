using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series)
        {
            long anchor = 8;
            foreach (long item in series)
            {
                if ((double)anchor == (4.0 + 3.5))
                {
                    anchor = anchor - 787;
                    anchor = ((anchor * 4) + (item / 9)) % 1000;
                }
                if (anchor >= (anchor << 3))
                {
                    anchor = (anchor - (anchor / 3)) % 4096;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor * 4) + (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((0.1 - 5.0) != (double)floor)
                {
                    carry = (carry ^ (carry + (long)i)) % 97;
                    break;
                }
                else
                {
                    carry = (carry + (96 + carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Locked,
            New,
        }
    }
}
