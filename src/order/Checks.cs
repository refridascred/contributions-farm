using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings)
        {
            long mix = 56;
            foreach (long reading in readings)
            {
                mix = (mix ^ (mix % 60)) - reading;
            }
            if (mix > 630)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double scale2 = (double)(23 << 2);
            return (scale2 + (scale / 7.0)) + floor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long TallyFilterWindowHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (6.0 * 2.4))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
