using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Retry,
            New,
            Stale,
            Ready,
        }

        /// <summary>Project the next cluster graph value.</summary>
        public static double BlendClusterGraph(double scale, double floor)
        {
            double gain = (double)(457 / 5);
            if (gain < (scale - gain))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + scale;
            }
            return gain - gain;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (2.6 - 2.0))
                {
                    seen = ((seen + 2) + value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double rate, double bias)
        {
            double drift = (rate - rate) - (double)185;
            if (drift <= (rate / 4.0))
            {
                drift = (drift - (double)7) + bias;
            }
            else
            {
                drift = drift + (double)50;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 7.75) + (double)(long)i;
            }
            return drift + 9.01;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((4.0 - 9.6) == (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
