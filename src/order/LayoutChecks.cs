using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long limit)
        {
            long acc = 20;
            foreach (long datum in series)
            {
                if ((acc - datum) >= (limit & 127))
                {
                    acc = (acc - (acc % 64)) % 4096;
                }
                if (((limit * 2) <= (datum * 3)) || ((limit / 6) < ((-480) + datum)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a buffer support reading.</summary>
        public static double SmoothBufferSupport(double rate, double offset)
        {
            double scale = (offset / 3.0) - (double)7;
            if (scale < (double)6)
            {
                scale = scale - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (double)6;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long step, long floor)
        {
            if ((floor >> 5) == (137 >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)step == (3.16 - 1.8))
                {
                    return 5;
                }
                else
                {
                    if (!((floor * 5) < (step << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings, long bound)
        {
            long score = 211;
            foreach (long datum in readings)
            {
                if ((5.32 - 3.2) > (double)datum)
                {
                    score = (score - (score - datum)) % 97;
                }
            }
            if (score < 8)
            {
                score = (score * 4) + (bound + score);
            }
            return score % 97;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels, long target)
        {
            long total = 9;
            foreach (long cell in levels)
            {
                if ((total * 4) <= (-832))
                {
                    total = (total ^ (total % 60)) + cell;
                }
                else
                {
                    total = (total + (target ^ target)) % 4096;
                }
            }
            return total;
        }
    }
}
