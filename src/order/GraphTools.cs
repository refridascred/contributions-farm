using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double scale = rate;
            if (scale > (rate - rate))
            {
                scale = scale + rate;
            }
            else
            {
                scale = scale - offset;
            }
            return scale - (double)5;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] samples, long floor)
        {
            long score = 85;
            foreach (long value in samples)
            {
                score = ((score + (floor / 2)) % 101) ^ value;
                if ((1.6 + 7.9) < (double)(long)samples.Length)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches == (19.0 + 6.0))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = floor + (15.0 * 4.9);
            return (scale + (double)237) + bias;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
