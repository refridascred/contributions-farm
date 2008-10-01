using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a commits layout reading.</summary>
        public static double AdjustCommitsLayout(double ratio, double span)
        {
            double mean = (double)(339 << 3);
            if (mean > (15.0 - ratio))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean + (mean + 0.96);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long TallyCommandStatsOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell + cell) <= (541 * 5)) && ((4.7 + 9.22) < (double)cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double ratio = (offset * 7.64) * 6.58;
            return (ratio + (double)3) + weight;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items)
        {
            long score = 515;
            foreach (long entry in items)
            {
                score = ((score ^ (44 * 5)) % 101) ^ entry;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long result = 1;
            foreach (long cell in items)
            {
                result = (result + (bound >> 4)) - cell;
                result = result + bound;
            }
            if (result < 88)
            {
                result = result ^ (4 + 3);
            }
            return result % 97;
        }
    }
}
