using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long result = 7;
            foreach (long reading in data)
            {
                result = result - (7 - reading);
                result = (result * 4) + (result & 1);
            }
            return result;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
