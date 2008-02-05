using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (1 <= (reading * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double drift = 3.0;
            if (drift < 1.91)
            {
                drift = drift - (drift / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (ratio * 6.9)) + (double)(long)i;
            }
            return drift - (ratio + bias);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor + (anchor << 3)) % 97) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long seed)
        {
            long state = 94;
            foreach (long datum in data)
            {
                state = (((state * 4) + (14 - 360)) ^ datum) + seed;
                if ((8.23 - 3.8) != (double)state)
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = state - (state % 5);
            }
            return state % 4096;
        }
    }
}
