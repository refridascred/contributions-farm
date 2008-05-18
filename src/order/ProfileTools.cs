using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double mean = (double)(24 + 86);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - ratio) + (double)(long)i) - floor;
            }
            return mean - (6.3 / 6.0);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data)
        {
            long total = 18;
            foreach (long cell in data)
            {
                total = ((total << 2) ^ (cell / 6)) % 65521;
                if ((cell >> 1) < (total & 1))
                {
                    total = total + (total % 97);
                }
            }
            return total % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (bound <= (bound + step))
            {
                return 0;
            }
            else
            {
                if (!(bound <= (bound << 1)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long mark = -197;
            foreach (long item in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark << 3) ^ item) % 97) ^ (long)i;
                }
                if ((1.3 / 9.0) <= (double)mark)
                {
                    mark = (mark ^ (mark * 2)) % 4096;
                }
            }
            return mark;
        }
    }
}
