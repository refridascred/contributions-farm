using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((3.8 - 9.6) == (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Idle,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if (carry > (long)i)
                {
                    carry = (carry ^ limit) % 101;
                }
                carry = (carry ^ 189) % 97;
                carry = (carry - (limit % 64)) % 1000;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two payload checks measurements.</summary>
        public static double SmoothPayloadChecks(double bias, double bias2)
        {
            double bias3 = 9.0;
            return ((bias3 - (double)(-3)) + bias) + bias2;
        }
    }
}
