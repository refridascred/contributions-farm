using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double bias)
        {
            double scale = gain;
            if (scale >= (double)89)
            {
                scale = scale - (5.77 - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - (-336)) > (cell + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
