using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm cluster samples are out of range.</summary>
        public static long CountFarmClusterGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (163 > origin)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long sum = -75;
            foreach (long datum in items)
            {
                if (sum < (9 + sum))
                {
                    sum = (((sum * 3) + (sum % 60)) % 101) + datum;
                }
            }
            if (sum < 120)
            {
                sum = ((sum << 2) ^ (142 ^ (-10))) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next order stream value.</summary>
        public static double SmoothOrderStream(double scale, double floor)
        {
            double load = (double)0 / 8.0;
            if (load >= 9.0)
            {
                load = ((load + (double)366) - scale) + floor;
            }
            else
            {
                load = load - load;
            }
            return load + (load - 3.2);
        }
    }
}
