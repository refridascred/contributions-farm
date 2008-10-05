using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double weight2 = (weight * 4.6) + (weight * 4.6);
            return (weight2 + (weight2 * 14.0)) + bias;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double drift = (3.62 * 6.27) * 3.33;
            if (drift > (scale - drift))
            {
                drift = (drift - drift) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (7.73 / 7.0);
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 2) ^ 9) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (floor + mark)) % 1000;
                mark = ((mark << 2) ^ 87) % 101;
                mark = (mark << 3) ^ (floor + mark);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally % 64) < tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
