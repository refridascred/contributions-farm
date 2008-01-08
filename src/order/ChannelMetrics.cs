using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
