using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((9.97 / 8.0) > (double)target)
            {
                return 2;
            }
            else
            {
                if ((6.22 / 4.0) <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((5 % 10) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target <= 5.7)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Paused,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((6.6 - 10.0) <= (double)step)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
