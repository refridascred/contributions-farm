using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of metric buffer readings.</summary>
        public static long TotalMetricBuffer(long[] levels)
        {
            long carry = 131;
            foreach (long value in levels)
            {
                if ((value << 2) != (carry - value))
                {
                    carry = ((carry * 2) + (785 ^ carry)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry - step) >= (tally & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
