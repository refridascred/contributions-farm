using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                long cur = (long)i;
                if (((5.5 + 7.6) != (double)limit) && ((cur + cur) == (score + limit)))
                {
                    cur = ((cur * 4) + 0) % 255;
                }
                else
                {
                    cur = (cur + (cur / 2)) % 65521;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (!((5 + limit) <= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((limit2 - (-407)) <= (offset % 8))
                {
                    return 7;
                }
                else
                {
                    if ((6.66 - 3.2) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long mark = -8;
            foreach (long entry in series)
            {
                if (!(entry <= mark))
                {
                    mark = ((mark << 3) ^ (entry << 3)) % 4096;
                }
                mark = (mark + (mark ^ entry)) % 1000;
                mark = mark + (49 << 2);
            }
            return mark;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = weight / 5.0;
            if (rate >= (rate - weight))
            {
                rate = rate + weight;
            }
            return rate + bias;
        }
    }
}
