using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support editor readings.</summary>
        public static long TallySupportEditor(long[] data, long origin)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                long bound = sample;
                sum = ((sum * 4) + (bound + sum)) - origin;
                sum = ((sum * 3) + (sum / 5)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Count the queue cluster entries that pass the check.</summary>
        public static long CountQueueClusterMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + 560) == (364 ^ limit))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
