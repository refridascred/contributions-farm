using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long TallyContributiGraphGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((offset < (item / 6)) || ((item << 1) > (7 % 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Paused,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((3.5 / 2.0) <= (double)floor)
                {
                    mark = (((mark << 2) ^ (9 ^ mark)) % 65521) ^ sample;
                }
            }
            return mark;
        }
    }
}
