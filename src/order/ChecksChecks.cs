using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (total - total)) % 97;
                for (int i3 = 0; i3 < 12; i3++)
                {
                    total = (((total << 3) ^ (seed * 3)) % 1000) - (long)i3;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double ratio = (double)4 * 6.82;
            if (ratio > ratio)
            {
                ratio = ratio + (span * 7.0);
            }
            else
            {
                ratio = ratio - (3.5 + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 15.0) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
