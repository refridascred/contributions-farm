using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long CountStreamSchemaMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally < (5.1 * 20.0))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double mean = gain;
            if (mean > (gain - 2.7))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean + (span - span);
            }
            return mean - gain;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((seed * 2) == (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
