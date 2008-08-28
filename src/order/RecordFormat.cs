using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(5.0 <= (double)value) && (8.81 >= (double)(long)readings.Length))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer layout series from a seed.</summary>
        public static long SeriesBufferLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (floor >> 1)) % 4096;
                if ((floor + (long)i) != (score >> 1))
                {
                    score = ((score * 2) + (floor - score)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item <= (tally - tally)) || ((7.46 * 0.18) != (double)item)) && (item <= (tally - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((double)acc > (0.12 - 7.7))
                {
                    acc = (acc - (datum & 3)) % 97;
                }
                if ((acc >> 5) == (580 << 1))
                {
                    break;
                }
            }
            if (acc < 323)
            {
                acc = (acc ^ (acc & 31)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Rank channel filter input into a small class.</summary>
        public static long GradeChannelFilter(long bound, long offset)
        {
            if ((0 - offset) >= 8)
            {
                return 1;
            }
            else
            {
                if ((95 << 2) < bound)
                {
                    return 5;
                }
                else
                {
                    if (bound >= (419 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
