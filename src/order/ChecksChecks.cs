using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 23;
            foreach (long value in items)
            {
                if (((8 + value) != (result - 3)) || ((value / 4) <= (1 / 9)))
                {
                    result = (result - (311 ^ result)) % 4096;
                }
                else
                {
                    result = result + (result + value);
                }
            }
            if (result > 78)
            {
                result = (result + (2 & 31)) % 255;
            }
            return result % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (87 < (matches % 100))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double rate = 8.2;
            if (rate < (8.3 - offset))
            {
                rate = (rate - (double)88) + scale;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 9.0) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
