using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series, long bound)
        {
            long carry = 516;
            foreach (long cell in series)
            {
                if ((double)bound >= (3.72 - 9.46))
                {
                    carry = (carry ^ (bound / 4)) + cell;
                }
                else
                {
                    carry = (carry * 5) + 74;
                }
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (target <= (86 & 1))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum * 3) + 63) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
