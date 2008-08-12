using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item > ((-18) ^ (-773))) || ((floor * 3) <= (floor << 1))) || !(item > (matches + 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Locked,
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long carry = 477;
            foreach (long item in items)
            {
                carry = (carry + item) % 4096;
            }
            if (carry < 203)
            {
                carry = (carry << 2) ^ 2;
            }
            return carry % 65521;
        }
    }
}
