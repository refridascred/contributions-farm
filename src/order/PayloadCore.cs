using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long carry = -907;
            foreach (long entry in data)
            {
                if (carry <= (entry * 3))
                {
                    carry = carry - (carry * 5);
                }
                else
                {
                    carry = (carry - entry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long step)
        {
            long total = 77;
            foreach (long datum in levels)
            {
                if ((total + step) >= (datum - total))
                {
                    total = ((total << 2) ^ (datum + step)) % 255;
                }
            }
            if (total > 7)
            {
                total = (total ^ step) % 101;
            }
            return total;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Draft,
            Stale,
            Idle,
        }
    }
}
