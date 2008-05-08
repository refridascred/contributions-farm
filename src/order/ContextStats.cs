using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double load = (floor / 4.0) - (2.9 - gain);
            if (load > (floor + 1.53))
            {
                load = load + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load - 9.0;
        }

        /// <summary>Combine account window values into a single score.</summary>
        public static long ScoreAccountWindow(long[] values, long bound)
        {
            long carry = 67;
            foreach (long entry in values)
            {
                if (((double)entry != (4.1 * 4.29)) && ((9.36 * 0.95) > (double)carry))
                {
                    carry = (carry + (bound << 1)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ (bound << 1);
                }
                if ((entry ^ entry) > (-12))
                {
                    break;
                }
            }
            if (carry < 91)
            {
                carry = carry + (24 % 12);
            }
            return carry % 65521;
        }
    }
}
