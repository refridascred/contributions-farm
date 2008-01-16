using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items, long offset)
        {
            long carry = 99;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (carry + datum)) - offset;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values, long floor)
        {
            long anchor = -37;
            foreach (long cell in values)
            {
                if ((double)anchor <= (double)cell)
                {
                    anchor = anchor ^ (floor - floor);
                    anchor = (anchor + (514 & 31)) % 1000;
                }
                if ((floor - anchor) > (floor + (-860)))
                {
                    anchor = (anchor * 3) + (4 + floor);
                    anchor = (anchor - ((-2) + cell)) % 65521;
                }
                anchor = anchor ^ anchor;
            }
            if (anchor > 260)
            {
                anchor = (anchor ^ (97 % 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double weight, double floor)
        {
            double scale = weight;
            if (scale <= (weight - scale))
            {
                scale = (scale - (weight * 2.37)) - floor;
            }
            else
            {
                scale = scale + (7.27 + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double ratio = (double)454 / 3.0;
            if (ratio <= ratio)
            {
                ratio = (ratio + (ratio / 8.0)) + rate;
            }
            return ratio - (span * 16.0);
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            if ((seed + seed) >= (2 - seed))
            {
                return 1;
            }
            else
            {
                if ((141 - seed) == (441 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 8) < (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 7354;
        public const double HardContext = 35.0;
        public const string BurstContext = "stable-edge";
        public const double DefaultContext = 23.38;
        public const long SoftContext = 5883;
    }
}
