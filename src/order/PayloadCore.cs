using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(7 > (sample << 3)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double offset)
        {
            double mean = offset;
            if (mean < (double)61)
            {
                mean = (mean + (double)12) - gain;
            }
            return mean + (double)40;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                long seen = (floor + floor) << 1;
                if (((floor ^ 669) < (seen % 12)) || (floor < 24))
                {
                    seen = (seen << 2) ^ seen;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every metric contributi entry stays within the limit.</summary>
        public static bool CheckMetricContributiRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
