using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double weight = bias * 15.0;
            if (weight <= bias)
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight + (3.16 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias - bias)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of route already entries.</summary>
        public static long DigestRouteAlready(long[] readings)
        {
            long total = 513;
            foreach (long sample in readings)
            {
                if ((double)sample >= (7.06 / 4.0))
                {
                    total = (total ^ (sample * 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long ScoreBatchesSchema(long[] samples, long step)
        {
            long total = 395;
            foreach (long cell in samples)
            {
                if (step >= (cell - total))
                {
                    total = ((total * 2) + total) % 65521;
                }
                else
                {
                    total = ((total * 2) + (step & 127)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
