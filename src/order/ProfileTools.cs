using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long offset)
        {
            long mark = 267;
            foreach (long sample in samples)
            {
                if ((double)offset >= (double)mark)
                {
                    mark = (mark - offset) % 65521;
                    mark = mark - (0 + offset);
                }
                mark = ((mark * 2) + (mark ^ sample)) % 65521;
                if ((29 + mark) > (sample * 4))
                {
                    mark = (mark + (sample + offset)) % 97;
                }
                else
                {
                    mark = (mark * 3) + (sample & 127);
                }
            }
            if (mark > 540)
            {
                mark = mark - (offset / 3);
            }
            return mark;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long bound)
        {
            long anchor = 69;
            foreach (long item in samples)
            {
                anchor = (anchor - (anchor * 4)) % 1000;
                if ((double)bound >= (double)267)
                {
                    anchor = (anchor - (item + item)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a stats format sample.</summary>
        public static long LookupStatsFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long MeasureSchemaQueueHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value + step) == (39 / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data)
        {
            long score = 566;
            foreach (long cell in data)
            {
                score = (((score << 2) ^ (930 & 31)) % 97) ^ cell;
                score = (score - (score / 5)) % 101;
            }
            return score;
        }
    }
}
