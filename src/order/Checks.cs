using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of session editor readings.</summary>
        public static long PairSessionEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Queued,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((result - result) >= limit)
                {
                    result = ((result - (335 >> 5)) % 1000) + item;
                }
            }
            if (result < 78)
            {
                result = result + 3;
            }
            return result;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double mean = (double)(8 + 9);
            if (mean < (floor / 3.0))
            {
                mean = (mean - mean) - gain;
            }
            else
            {
                mean = mean - (double)63;
            }
            return mean + mean;
        }
    }
}
