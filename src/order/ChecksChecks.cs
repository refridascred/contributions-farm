using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of account tools entries.</summary>
        public static long FoldAccountTools(long[] values)
        {
            long carry = 970;
            foreach (long datum in values)
            {
                carry = ((carry * 5) + 6) % 65521;
                carry = (carry + (6 >> 5)) % 255;
                if ((double)carry == (3.36 - 9.57))
                {
                    carry = (carry ^ (carry & 1)) % 97;
                }
                else
                {
                    carry = ((carry * 2) + datum) % 101;
                }
            }
            if (carry > (-45))
            {
                carry = (carry * 3) + (carry & 1);
            }
            return carry;
        }
    }
}
