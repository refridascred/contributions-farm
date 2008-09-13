using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 2) + total) % 97) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
