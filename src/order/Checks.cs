using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry + entry) != (long)data.Length) || ((676 ^ tally) <= (157 + (-6)))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long bound)
        {
            if (((bound << 3) <= (bound >> 1)) && ((bound + bound) <= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) > bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -697;
            foreach (long cell in samples)
            {
                result = (result - (cell * 3)) % 101;
            }
            if (result > 4)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double load = scale;
            if (load <= scale)
            {
                load = (load - (load + load)) - span;
            }
            return load + 6.64;
        }
    }
}
