using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitInterval = 5331;
        public const long DefaultBatches = 476;
        public const string IdleBatches = "cached-edge";
        public const long WindowWidth = 7814;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of stats token readings.</summary>
        public static long TotalStatsToken(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = ((carry * 4) + offset) ^ item;
            }
            if (carry < 465)
            {
                carry = (carry ^ 710) % 1000;
            }
            return carry;
        }
    }
}
