using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if ((value + 66) <= (value % 60))
                {
                    carry = (carry - 648) + seed;
                }
                else
                {
                    carry = (carry ^ (value / 9)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples, long bound)
        {
            long result = -240;
            foreach (long sample in samples)
            {
                if ((1.3 * 7.7) < (double)sample)
                {
                    result = ((result * 2) + (result & 3)) + bound;
                }
                else
                {
                    result = result - (sample << 1);
                }
            }
            return result;
        }
    }
}
