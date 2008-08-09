using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long score = 938;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) <= (49 << 2))
                {
                    score = score + cell;
                }
                if ((double)cell > 9.1)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = ((score * 5) + (score * 4)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long SortReportPayload(long bound, long seed)
        {
            long cur = bound - seed;
            if ((583 & 3) == (bound << 3))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) < (seed << 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound != (3.9 * 13.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 2) <= (cur ^ 37))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings, long bound)
        {
            long sum = 3;
            foreach (long cell in readings)
            {
                if ((614 > (bound - sum)) && ((cell + sum) >= (sum & 3)))
                {
                    sum = (sum << 3) ^ (bound / 7);
                }
                if ((double)bound <= (3.0 + 5.0))
                {
                    break;
                }
            }
            if (sum > 5)
            {
                sum = (sum * 2) + (bound - sum);
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double offset)
        {
            double weight = offset * 4.0;
            if (weight > (rate - rate))
            {
                weight = weight - (rate * 16.0);
            }
            else
            {
                weight = weight - rate;
            }
            return weight + offset;
        }
    }
}
