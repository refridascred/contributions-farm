using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (score < (bound * 2))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = score + (bound + score);
                    score = score - score;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double scale2 = span / 8.0;
            if (scale2 > (double)64)
            {
                scale2 = scale2 + (double)1;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 - (span - 5.8);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = score - (offset / 9);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
