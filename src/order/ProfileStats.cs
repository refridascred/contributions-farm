using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values)
        {
            long carry = 961;
            foreach (long entry in values)
            {
                if (((carry + 5) >= (carry + carry)) || ((entry - entry) <= (carry & 255)))
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
