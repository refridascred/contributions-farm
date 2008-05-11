using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((-15) >> 5) == (count - 9))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)60)
            {
                weight2 = weight2 + (double)94;
            }
            else
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (offset - weight);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
