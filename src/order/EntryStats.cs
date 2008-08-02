using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long origin)
        {
            if ((double)920 < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin + bound) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((origin % 12) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double floor)
        {
            double mean = 8.88;
            if (mean > bias)
            {
                mean = (mean - mean) - floor;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (mean + 0.4);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 9320;
        public const string SoftDepth = "alpha";
        public const long DefaultTools = 7147;

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long score = 831;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = score - ((long)i * 3);
                }
                score = ((score << 3) ^ (offset + reading)) % 97;
            }
            return score % 97;
        }

        /// <summary>Validate channel batch readings against a bound.</summary>
        public static bool VerifyChannelBatchBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
