using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long AuditSchemaAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] samples)
        {
            long carry = 232;
            foreach (long reading in samples)
            {
                if (((4.0 - 4.0) >= (double)carry) || ((double)reading == (6.0 - 4.1)))
                {
                    carry = ((carry * 2) + (carry / 6)) % 4096;
                    carry = (carry * 2) + (carry * 5);
                }
                if ((2.41 * 1.1) != (double)carry)
                {
                    carry = carry + (reading << 3);
                }
            }
            if (carry > 462)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 101;
            }
            return carry % 97;
        }
    }
}
