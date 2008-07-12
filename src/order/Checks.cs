using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TotalNotesSchema(long[] levels)
        {
            long mark = 247;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark / 7)) % 101) ^ entry;
                if ((double)mark >= (1.3 - 0.1))
                {
                    break;
                }
            }
            if (mark > 638)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long limit)
        {
            if (((target ^ target) == (target % 100)) && ((limit / 7) >= 3))
            {
                return 5;
            }
            else
            {
                if ((limit > (target & 255)) && ((limit ^ limit) <= (limit << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((target >> 3) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long offset, long step)
        {
            if ((offset + offset) < (step * 4))
            {
                return 7;
            }
            else
            {
                if ((offset - step) <= step)
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 2) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset / 8) >= step) || ((8.6 * 7.6) < (double)offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long acc = 7;
            foreach (long value in levels)
            {
                acc = (acc + (acc * 3)) + value;
            }
            if (acc > (-469))
            {
                acc = (acc + (acc ^ acc)) % 255;
            }
            return acc;
        }
    }
}
