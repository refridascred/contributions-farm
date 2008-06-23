using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long origin)
        {
            long score = 31;
            foreach (long sample in data)
            {
                if (score >= origin)
                {
                    score = ((score + (origin * 2)) % 65521) - sample;
                }
            }
            if (score > 17)
            {
                score = (score + (score & 7)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i != (mark + mark))
                {
                    mark = (mark * 3) + (mark - mark);
                    mark = ((mark * 2) + (827 + mark)) % 97;
                }
                else
                {
                    mark = (mark ^ ((long)i * 5)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batches format samples are out of range.</summary>
        public static long AuditBatchesFormatGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((double)seed >= (9.2 / 9.0)) || (hits <= (857 + seed))))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double offset)
        {
            double ratio = (double)316 + (offset / 5.0);
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (rate - ratio);
        }
    }
}
