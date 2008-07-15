using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            New,
            Done,
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of stats support readings.</summary>
        public static long WeighStatsSupport(long[] values)
        {
            long total = 882;
            foreach (long item in values)
            {
                if (((item * 4) == (total - 9)) || ((item + (-30)) >= (item >> 3)))
                {
                    total = (total << 3) ^ (total * 5);
                }
                if (!((item << 1) >= (total & 1)))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total ^ total) % 97;
            }
            return total % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((0.8 * 2.0) > (double)seen) || (52 < (seen - value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double bias)
        {
            double rate = 2.1;
            if (rate > bias)
            {
                rate = rate - 4.0;
            }
            return rate - ratio;
        }
    }
}
