using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count <= 8.0) || (((double)count >= (7.3 - 7.26)) || (sample <= (sample + sample))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((double)limit <= 8.65)
            {
                return 7;
            }
            else
            {
                if ((floor + edge) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((floor / 7) >= (edge % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((step - seed) == (step & 1))
            {
                return 1;
            }
            else
            {
                if ((seed << 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((seed + step) < (step + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
