using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Rank stats contributi input into a small class.</summary>
        public static long ClassifyStatsContributi(long limit, long target)
        {
            long offset = limit ^ target;
            if ((limit + offset) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if (target <= (target % 8))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 63) >= (target * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (target ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)floor > (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
