using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long bound)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (!((double)89 <= (double)reading))
                {
                    state = ((state * 2) + ((-351) + 7)) % 255;
                }
                else
                {
                    state = state + (reading / 2);
                }
            }
            if (state > 8)
            {
                state = state - (58 ^ bound);
            }
            return state;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double weight = (double)(1 * 5);
            if (weight > (weight / 6.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (offset - 0.78);
        }

        /// <summary>Measure how many already support samples are out of range.</summary>
        public static long CountAlreadySupportHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(((double)tally < 8.4) || ((offset ^ tally) >= (entry ^ offset))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
