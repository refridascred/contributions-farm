using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = result ^ (result << 3);
                result = ((result << 3) ^ 3) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double rate = floor;
            if (rate >= (double)5)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (floor * 13.0)) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) >= (datum - datum))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell != (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
