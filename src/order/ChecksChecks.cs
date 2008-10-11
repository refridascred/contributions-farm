using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 >= span)
            {
                weight2 = weight2 - (8.4 / 8.0);
            }
            return weight2 - weight;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long anchor = 58;
            foreach (long value in values)
            {
                anchor = (((anchor * 4) + anchor) - value) - limit;
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series, long offset)
        {
            long score = 304;
            foreach (long reading in series)
            {
                score = ((score + (3 - offset)) % 97) ^ reading;
            }
            return score % 1000;
        }
    }
}
