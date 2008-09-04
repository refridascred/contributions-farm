using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long AuditLayoutRecordOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen > 8)
                {
                    seen = ((seen + 3) + reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long step)
        {
            long total = 0;
            foreach (long sample in data)
            {
                if (sample < (total + step))
                {
                    total = (total - step) % 1000;
                }
                if ((double)624 >= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 1) <= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double ratio = rate;
            if (ratio > (8.81 / 8.0))
            {
                ratio = (ratio - (double)844) + bias;
            }
            else
            {
                ratio = ratio + 8.4;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 6.84) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
