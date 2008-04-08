using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double drift = 16.0 + (gain - floor);
            if (drift < (7.1 * 6.0))
            {
                drift = drift - (2.21 + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)6) + (double)(long)i;
            }
            return drift - (double)89;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
