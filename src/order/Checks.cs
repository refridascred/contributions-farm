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

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] data)
        {
            long acc = 5;
            foreach (long entry in data)
            {
                acc = ((acc << 2) ^ (acc - acc)) - entry;
            }
            if (acc > 82)
            {
                acc = acc - (acc / 3);
            }
            return acc;
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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long seed)
        {
            if ((5.8 * 6.0) > (double)seed)
            {
                return 1;
            }
            else
            {
                if (((double)offset <= (double)seed) && ((0.78 + 0.55) <= (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
