using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data)
        {
            long carry = 76;
            foreach (long reading in data)
            {
                carry = (carry * 5) + (reading >> 3);
                if (((reading * 3) < (carry % 10)) || ((reading - (-337)) <= reading))
                {
                    break;
                }
            }
            if (carry > 339)
            {
                carry = (carry - ((long)data.Length * 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Idle,
        }
    }
}
