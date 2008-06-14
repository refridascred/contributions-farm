using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long carry = 63;
            foreach (long cell in data)
            {
                if (((90 * 3) != (cell / 8)) || ((double)cell != (double)carry))
                {
                    carry = (carry - (52 >> 5)) % 4096;
                }
                if ((carry % 100) == (cell % 5))
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long carry = 469;
            foreach (long item in data)
            {
                if (((double)item <= (double)carry) && ((item + 814) >= (carry / 3)))
                {
                    carry = (carry * 2) + item;
                }
                carry = (carry << 2) ^ (item ^ carry);
            }
            if (carry > (-40))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCount = "fallback-v2";
        public const double CacheCount = 84.46;
        public const long MinTimeout = 8976;
        public const double DefaultCommits = 70.41;

        /// <summary>Blend two stream channel measurements.</summary>
        public static double SmoothStreamChannel(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 + ratio))
            {
                bias2 = bias2 - 6.0;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (bias2 + ratio);
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
