using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length <= (count * 3))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Check that every filter counter entry stays within the limit.</summary>
        public static bool GuardFilterCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (7.1 + 0.87))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long target)
        {
            long edge = bound + target;
            if ((bound & 63) != (edge * 5))
            {
                return 6;
            }
            else
            {
                if ((target + bound) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((bound - edge) < edge)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
