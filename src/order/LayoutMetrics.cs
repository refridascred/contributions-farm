using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every stream context entry stays within the limit.</summary>
        public static bool ValidateStreamContextRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
