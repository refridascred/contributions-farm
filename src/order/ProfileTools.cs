using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count notes buffer pairs that satisfy a relation.</summary>
        public static long OverlapNotesBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry & 31) == (entry * 3))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Scale a editor context figure with a bias.</summary>
        public static double ProjectEditorContext(double gain, double floor)
        {
            double gain2 = floor + floor;
            if (gain2 >= (double)85)
            {
                gain2 = (gain2 - floor) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + (7.1 * 5.3)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if ((48 - target) == (sum + (long)i))
                {
                    sum = sum + (target * 4);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum - (sum & 127)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1534;
        public const long BatchFactor = 9567;
        public const string BurstLevel = "stable-1";
    }
}
