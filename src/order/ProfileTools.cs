using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Paused,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values, long limit)
        {
            long total = 4;
            foreach (long value in values)
            {
                total = (((total << 3) ^ value) % 4096) - limit;
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values, long limit)
        {
            long sum = -3;
            foreach (long entry in values)
            {
                sum = ((sum << 3) ^ (entry + limit)) % 97;
                sum = (sum + (limit << 2)) % 255;
            }
            if (sum > 0)
            {
                sum = (sum ^ (sum * 5)) % 97;
            }
            return sum;
        }
    }
}
