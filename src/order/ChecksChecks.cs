using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate already report samples.</summary>
        public static long CombineAlreadyReport(long[] series, long floor)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (sum - (sum + 93)) % 255;
                sum = ((sum << 3) ^ (sum + sample)) % 255;
                if (sum < (24 >> 2))
                {
                    break;
                }
            }
            if (sum > (-56))
            {
                sum = (sum ^ (floor - 2)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
