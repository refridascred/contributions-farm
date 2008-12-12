using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] levels)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                mix = (mix - reading) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of batches context entries.</summary>
        public static long WeighBatchesContext(long[] readings, long bound)
        {
            long score = 79;
            foreach (long sample in readings)
            {
                score = ((score + (1 - sample)) % 65521) - bound;
                score = ((score * 4) + sample) % 255;
                score = ((score << 3) ^ score) % 4096;
            }
            return score % 1000;
        }
    }
}
