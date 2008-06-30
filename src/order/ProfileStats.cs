using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (!((slot / 8) <= (slot >> 4)))
            {
                return 2;
            }
            else
            {
                if (0.41 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (7.1 * 3.4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-963) >= (floor << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format record samples are out of range.</summary>
        public static long MeasureFormatRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 2) == (count & 15))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
