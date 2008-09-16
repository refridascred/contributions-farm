using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long floor)
        {
            long carry = 249;
            foreach (long sample in data)
            {
                if ((floor / 6) >= 7)
                {
                    carry = (carry ^ sample) % 97;
                }
            }
            if (carry > 2)
            {
                carry = ((carry << 2) ^ (floor ^ carry)) % 255;
            }
            return carry;
        }

        /// <summary>Scale a context window figure with a bias.</summary>
        public static double ScaleContextWindow(double rate, double offset)
        {
            double bias = (double)6 + (double)(-4);
            if (bias < (9.44 + offset))
            {
                bias = (bias + 6.51) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Locked,
            Paused,
        }
    }
}
