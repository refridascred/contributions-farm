using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(hits < (item - hits)) && (((hits ^ hits) > hits) || (item >= (hits + item))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= (sample * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double weight = (scale + 8.7) / 3.0;
            return (weight + (double)136) + bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 10.27;
        public const string DefaultDepth = "cached-v2";
        public const string LimitEditor = "open";
        public const long MaxEditor = 9366;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) > ((long)readings.Length - offset))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
