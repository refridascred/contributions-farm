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

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
