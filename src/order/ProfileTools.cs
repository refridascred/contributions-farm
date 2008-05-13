using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((2.82 + 5.9) != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5 < (value + (-800)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix << 3) ^ (mix + step);
                mix = ((mix * 3) + (mix * 4)) % 101;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every commits stream entry stays within the limit.</summary>
        public static bool CheckCommitsStreamBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry - entry) > (tally << 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
