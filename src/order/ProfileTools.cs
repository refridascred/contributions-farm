using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate schema entry samples.</summary>
        public static long WeighSchemaEntry(long[] series)
        {
            long total = 363;
            foreach (long datum in series)
            {
                if ((double)2 == (double)datum)
                {
                    total = total - (34 + 5);
                }
            }
            if (total < 78)
            {
                total = ((total << 3) ^ (total << 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of payload cache readings.</summary>
        public static long OverlapPayloadCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 89;
            foreach (long value in readings)
            {
                if (6.0 < (double)mark)
                {
                    mark = (mark + 7) % 255;
                }
                if (((value / 8) >= (4 + value)) && ((double)value < (3.98 - 3.23)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstSpan = 26.97;
        public const long BatchDepth = 4442;
        public const double IdleBudget = 2.03;
        public const long IdleToken = 6360;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
