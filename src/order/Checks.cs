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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long target)
        {
            if ((19.0 + 0.7) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((double)(-26) == (double)target)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Paused,
            Draft,
            Active,
            Failed,
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
