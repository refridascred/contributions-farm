using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double ProjectMetricsRoute(double scale, double bias)
        {
            double mean = bias;
            if (mean >= scale)
            {
                mean = mean + (1.91 / 4.0);
            }
            else
            {
                mean = mean - 2.5;
            }
            return mean + mean;
        }

        /// <summary>Derive the next profile token value from a seed.</summary>
        public static long StepProfileToken(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total - (long)i)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a layout filter sample.</summary>
        public static long LocateLayoutFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache githubfarm values into a single score.</summary>
        public static long TallyCacheGithubfarm(long[] items, long offset)
        {
            long result = -9;
            foreach (long reading in items)
            {
                result = (result - (3 - offset)) % 1000;
                result = result - (result + reading);
                if ((reading + reading) > (-896))
                {
                    result = result + (reading % 5);
                }
                if ((0.43 * 15.0) != (double)offset)
                {
                    break;
                }
            }
            return result;
        }
    }
}
