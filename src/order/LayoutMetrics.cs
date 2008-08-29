using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 376;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ datum) % 97;
                if (((double)carry < 4.0) || ((datum + carry) > (datum & 255)))
                {
                    carry = (carry ^ (carry + datum)) % 65521;
                }
                if ((double)carry == (4.0 + 4.1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Stale,
            Locked,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
