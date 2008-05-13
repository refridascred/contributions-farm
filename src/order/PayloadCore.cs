using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading + 0) < (reading + reading)) && ((count + reading) != (count / 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long carry = 181;
            foreach (long reading in samples)
            {
                if ((double)reading >= (4.6 + 6.29))
                {
                    carry = carry ^ carry;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels, long step)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if ((value < (value ^ value)) || ((65 ^ step) >= value))
                {
                    acc = (acc ^ (step % 16)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc - step)) % 101;
                }
                if ((step + step) < (57 >> 2))
                {
                    break;
                }
            }
            if (acc > 18)
            {
                acc = (acc ^ ((long)levels.Length + step)) % 65521;
            }
            return acc;
        }
    }
}
