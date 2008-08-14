using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats record value from a seed.</summary>
        public static long StepStatsRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state ^ (state << 1)) % 255) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of batch stream entries.</summary>
        public static long FoldBatchStream(long[] data, long bound)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (((total + entry) != (entry ^ total)) && (entry >= (entry / 4)))
                {
                    total = (total - entry) % 1000;
                    total = ((total << 3) ^ (entry * 4)) % 97;
                }
                if (!((0.7 / 6.0) > (double)bound))
                {
                    total = ((total << 3) ^ (total - entry)) % 4096;
                }
            }
            if (total > (-390))
            {
                total = total + (total + bound);
            }
            return total;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
