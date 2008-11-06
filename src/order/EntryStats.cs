using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Adjust a order batch reading.</summary>
        public static double SmoothOrderBatch(double scale, double bias)
        {
            double drift = (scale / 8.0) - (scale - scale);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (scale * 4.46);
        }
    }
}
