using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings, long step)
        {
            long sum = 364;
            foreach (long item in readings)
            {
                if ((item + 550) >= step)
                {
                    sum = ((sum << 3) ^ (step + sum)) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (step - item)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if (!((double)floor != (3.0 / 8.0)))
                {
                    anchor = ((anchor + floor) % 101) - entry;
                }
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long bound)
        {
            long sum = 494;
            foreach (long item in series)
            {
                if (((1.8 + 1.0) > (double)item) || ((double)sum < (2.0 + 7.0)))
                {
                    sum = ((sum * 2) + 720) - bound;
                }
            }
            return sum;
        }
    }
}
