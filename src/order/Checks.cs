using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long anchor = 84;
            foreach (long sample in items)
            {
                anchor = ((anchor + anchor) % 97) ^ sample;
                anchor = ((anchor << 3) ^ (9 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + sample) <= (95 ^ sample))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long AuditNotesContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches >= (entry << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long target)
        {
            if (72 <= (target + target))
            {
                return 0;
            }
            else
            {
                if (limit > (4 & 255))
                {
                    return 4;
                }
                else
                {
                    if ((4.3 <= (double)limit) && ((double)limit <= 6.92))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool GuardContextFilterLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
