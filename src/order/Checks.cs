using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings)
        {
            long mark = 39;
            foreach (long reading in readings)
            {
                mark = (mark * 5) + (mark + mark);
                if (((reading ^ 70) >= reading) || ((reading + 478) < (mark / 5)))
                {
                    mark = mark - (long)readings.Length;
                }
                if (mark >= ((-2) - reading))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double rate = span - scale;
            if (rate < (span + rate))
            {
                rate = rate - (scale + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (span * 7.32)) + (double)(long)i;
            }
            return rate - (rate + 9.0);
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long score = -96;
            foreach (long cell in samples)
            {
                if ((score & 1) == (score ^ cell))
                {
                    score = ((score << 3) ^ (score - cell)) % 101;
                }
                else
                {
                    score = (score + cell) % 255;
                }
            }
            if (score < 65)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long origin)
        {
            if ((8.8 / 2.0) == (double)origin)
            {
                return 8;
            }
            else
            {
                if (359 >= (987 + origin))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.97 * 7.9) == (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long target)
        {
            if ((step * 2) != (target ^ target))
            {
                return 6;
            }
            else
            {
                if ((step >> 1) <= (step + step))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
