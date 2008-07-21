using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (origin * 2)) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long offset)
        {
            long total = 967;
            foreach (long value in samples)
            {
                total = (total + (value ^ total)) % 4096;
                if ((offset + total) > offset)
                {
                    total = (total ^ (total - value)) % 1000;
                }
            }
            if (total < 4)
            {
                total = (total - (offset - 449)) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of report counter readings.</summary>
        public static long PairReportCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
