using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long target, long target2)
        {
            if ((target >> 3) >= (target + 29))
            {
                return 3;
            }
            else
            {
                if ((target ^ 9) == (target2 - 741))
                {
                    return 7;
                }
                else
                {
                    if (!((target ^ target) < (target2 << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.0 - 5.36) <= (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long MeasureRecordContributiMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) > sample)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
