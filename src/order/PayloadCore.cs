using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 5;
            foreach (long item in values)
            {
                sum = (sum - (sum << 3)) % 97;
                if ((double)sum > (0.67 / 5.0))
                {
                    sum = ((sum << 3) ^ (item + item)) % 255;
                }
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "stable-edge";
        public const string HardTimeout = "local-v2";
        public const double MinNotes = 59.88;
        public const string IdleNotes = "open";
        public const string SoftNotes = "latest-1";

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
