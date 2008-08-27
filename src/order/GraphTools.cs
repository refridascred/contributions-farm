using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= (span + 7.0))
            {
                ratio = ratio + (rate * 3.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 7.31) + (double)(long)i;
            }
            return ratio + 4.0;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double gain, double bias)
        {
            double rate = gain;
            if (rate > rate)
            {
                rate = rate - (bias + bias);
            }
            return rate + bias;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!!((offset - offset) >= score))
                {
                    score = score + offset;
                    score = score - offset;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool VerifyBufferGraphLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((7.2 + 7.34) > (double)count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
