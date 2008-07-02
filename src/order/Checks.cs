using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Count the graph entry entries that pass the check.</summary>
        public static long CountGraphEntryOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample * 5) > sample) && ((sample + sample) <= (6 & 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format stream samples.</summary>
        public static long FoldFormatStream(long[] items, long target)
        {
            long carry = 3;
            foreach (long value in items)
            {
                carry = (carry - target) % 4096;
                if ((target & 31) <= (3 + 89))
                {
                    carry = carry + (long)items.Length;
                }
                if ((581 + carry) > (target - carry))
                {
                    carry = ((carry * 2) + (33 << 2)) % 101;
                }
                if (((double)carry == (6.0 + 7.1)) || (value < (573 << 3)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double mean = (double)(44 * 4);
            if (mean >= bias)
            {
                mean = mean + (6.5 + mean);
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - (double)5;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Locked,
            Pending,
            Paused,
            New,
        }
    }
}
