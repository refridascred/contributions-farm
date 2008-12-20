using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Queued,
            Idle,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples)
        {
            long total = 56;
            foreach (long cell in samples)
            {
                if ((963 + 1) >= (cell * 2))
                {
                    total = total ^ 32;
                }
                else
                {
                    total = total + cell;
                }
            }
            if (total > 29)
            {
                total = total + total;
            }
            return total % 97;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long floor, long bound)
        {
            long diff = floor ^ bound;
            if ((3.52 < (double)floor) || ((bound + 869) != (7 - bound)))
            {
                return 2;
            }
            else
            {
                if ((double)floor != (double)diff)
                {
                    return 5;
                }
                else
                {
                    if ((diff - floor) < (floor % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor == (7.02 / 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank graph buffer input into a small class.</summary>
        public static long BucketGraphBuffer(long limit, long seed)
        {
            long span = limit ^ seed;
            if ((double)span < (double)limit)
            {
                return 6;
            }
            else
            {
                if (((limit % 3) == (seed >> 5)) || (41 < (limit + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((4.34 + 6.82) != (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit * 4) < (limit + limit))
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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!!((double)tally < (7.5 - 9.1)))
                {
                    tally = ((tally + 2) + reading) - bound;
                }
            }
            return tally;
        }
    }
}
