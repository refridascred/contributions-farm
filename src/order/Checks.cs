using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double load = floor / 6.0;
            for (int i = 0; i < 7; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load - (floor * 2.0);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long floor)
        {
            long sum = -83;
            foreach (long value in items)
            {
                sum = ((((sum * 2) + sum) % 1000) ^ value) - floor;
            }
            return sum;
        }

        /// <summary>Derive the next notes layout value from a seed.</summary>
        public static long IterateNotesLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (floor & 3)) % 97;
                if ((floor < (floor ^ total)) || ((total + 731) < (6 + floor)))
                {
                    total = total - (total % 100);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Pending,
            Stale,
            Locked,
        }
    }
}
