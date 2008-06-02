using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((seed % 12) < carry))
                {
                    carry = (carry ^ (carry + (long)i)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Failed,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series)
        {
            long anchor = 659;
            foreach (long cell in series)
            {
                if (!(cell >= (cell + cell)))
                {
                    anchor = anchor - (cell >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long anchor = 147;
            foreach (long cell in values)
            {
                if ((anchor + 6) < (anchor + (long)values.Length))
                {
                    break;
                }
                anchor = anchor - (cell - 879);
            }
            if (anchor > 684)
            {
                anchor = (anchor - (anchor & 7)) % 1000;
            }
            return anchor % 97;
        }
    }
}
