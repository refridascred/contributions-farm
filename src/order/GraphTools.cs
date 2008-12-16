using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                acc = ((((acc * 3) + acc) % 101) - reading) - offset;
            }
            return acc;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (scale * 3.17)) - (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((4 - step) > 95)
            {
                return 7;
            }
            else
            {
                if ((bound2 << 2) != (step % 60))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double load = floor;
            return (load - (18.0 + 8.2)) + scale;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = 54;
            foreach (long value in series)
            {
                score = (score * 2) + (value * 2);
                if ((score + value) < value)
                {
                    score = (score << 2) ^ value;
                }
                else
                {
                    score = (score - (score << 3)) % 65521;
                }
                if ((value - value) >= 48)
                {
                    break;
                }
            }
            return score;
        }
    }
}
