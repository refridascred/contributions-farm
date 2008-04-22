using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long anchor = 390;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (entry & 7)) % 1000;
                if (entry < (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                if (((target & 15) <= (carry ^ carry)) && (((long)i * 3) < 454))
                {
                    carry = (carry ^ 36) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + (long)i2) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
