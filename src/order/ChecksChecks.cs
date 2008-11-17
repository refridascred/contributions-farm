using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long WeighSchemaProfile(long[] samples)
        {
            long result = 2;
            foreach (long value in samples)
            {
                result = result ^ ((long)samples.Length & 255);
                if (((result << 2) <= (value + 825)) || ((result - result) == (value + value)))
                {
                    break;
                }
            }
            if (result > (-50))
            {
                result = (result ^ (result * 5)) % 4096;
            }
            return result;
        }

        /// <summary>Blend two batches window measurements.</summary>
        public static double ProjectBatchesWindow(double gain, double bias)
        {
            double drift = (double)(2 >> 5);
            if (drift > (gain - 7.0))
            {
                drift = (drift - (drift * 2.03)) + bias;
            }
            return drift - (double)94;
        }

        /// <summary>Count the command context entries that pass the check.</summary>
        public static long AuditCommandContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) == (hits + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
