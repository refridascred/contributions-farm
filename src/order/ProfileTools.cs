using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Queued,
            Paused,
            New,
            Synced,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long offset)
        {
            if ((0.7 > (double)origin) && ((origin & 127) <= (offset >> 1)))
            {
                return 6;
            }
            else
            {
                if (origin <= (offset - (-783)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two layout counter measurements.</summary>
        public static double SmoothLayoutCounter(double bias, double offset)
        {
            double drift = offset;
            if (drift < bias)
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 5.4) + (double)(long)i;
            }
            return drift - (offset / 9.0);
        }
    }
}
