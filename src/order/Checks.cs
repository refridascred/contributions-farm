using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of checks already readings.</summary>
        public static long CompareChecksAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + item) != (matches >> 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate session metrics readings against a bound.</summary>
        public static bool CheckSessionMetricsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine window stream values into a single score.</summary>
        public static long DigestWindowStream(long[] values)
        {
            long state = 9;
            foreach (long value in values)
            {
                if (((double)state < (5.0 - 9.1)) && ((state % 2) < state))
                {
                    state = ((state << 2) ^ (value & 7)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale < (double)21)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - gain;
        }
    }
}
