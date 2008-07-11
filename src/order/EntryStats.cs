using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long step)
        {
            if ((double)step > (20.0 / 6.0))
            {
                return 6;
            }
            else
            {
                if (!((6.75 / 4.0) == (double)step))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long GradeSupportOrder(long offset, long limit)
        {
            long lane = offset + limit;
            if ((offset % 8) < lane)
            {
                return 0;
            }
            else
            {
                if (4.3 <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((2.7 * 1.0) >= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
