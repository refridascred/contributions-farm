using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of counter farm readings.</summary>
        public static long PairCounterFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Queued,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double gain, double offset)
        {
            double mean = offset - (double)0;
            return mean + gain;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long origin2)
        {
            long offset = origin ^ origin2;
            if ((double)origin2 == (double)217)
            {
                return 4;
            }
            else
            {
                if (((origin2 + origin2) >= (offset + 73)) && ((offset + 657) <= (offset % 16)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 >= (6.6 + 6.81))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
