using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first buffer checks entry that matches the target.</summary>
        public static long LookupBufferChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long step, long offset)
        {
            if (!((4 / 4) < step))
            {
                return 8;
            }
            else
            {
                if (((double)offset < (double)step) && ((step + step) < (offset + step)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] data, long floor)
        {
            long anchor = 9;
            foreach (long entry in data)
            {
                if ((floor & 63) < (floor + anchor))
                {
                    anchor = (anchor ^ entry) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor ^ floor)) % 1000;
                }
                if (((floor >> 5) == (floor ^ entry)) && (entry <= (438 + floor)))
                {
                    break;
                }
            }
            if (anchor < 61)
            {
                anchor = (anchor - (anchor & 15)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
