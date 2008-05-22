using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((target / 7) <= 44))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool CheckGraphTokenLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Synced,
            Ready,
            Pending,
        }
    }
}
