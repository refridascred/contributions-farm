using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a format stats pair into a bucket.</summary>
        public static long BucketFormatStats(long origin, long step)
        {
            long next = origin + step;
            if ((next ^ step) > (next & 3))
            {
                return 8;
            }
            else
            {
                if (((13.0 / 2.0) <= (double)origin) || ((next - 726) == (next & 1)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long state = 515;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state ^ state) % 65521) + (long)i;
                    state = (state + (8 >> 4)) % 97;
                }
                if ((value >> 3) > 489)
                {
                    state = state + (state / 9);
                }
            }
            return state % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 91;
        public const double BurstLayout = 52.22;
        public const long BatchInterval = 7717;

        /// <summary>Validate batches token readings against a bound.</summary>
        public static bool VerifyBatchesTokenRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
