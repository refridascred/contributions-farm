using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + offset) <= (tally << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 386) > (reading ^ 1))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long target)
        {
            long sum = 913;
            foreach (long sample in readings)
            {
                if (!((double)sum != (2.0 / 4.0)))
                {
                    sum = sum ^ (target + target);
                }
                sum = sum ^ (sum << 3);
                if (!((7.8 + 9.88) > (double)sample))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double rate, double floor)
        {
            double scale = rate + rate;
            if (scale <= (double)2)
            {
                scale = scale - floor;
            }
            return scale - (floor - rate);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
