using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            New,
            Done,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples, long target)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if (!((datum & 31) == (score + (long)samples.Length)))
                {
                    score = (score ^ (score + datum)) % 97;
                }
                else
                {
                    score = (score ^ (target - datum)) % 65521;
                }
                if ((target <= (target - target)) || ((target >> 1) != (datum - target)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)84 >= (double)item)
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }
    }
}
