using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((target >= (tally >> 2)) && !(target <= tally))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long CombineChecksFormat(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = ((((mark * 2) + mark) % 4096) ^ cell) + bound;
                mark = (mark - (845 * 5)) % 4096;
            }
            if (mark < 38)
            {
                mark = (mark - (long)samples.Length) % 101;
            }
            return mark;
        }
    }
}
