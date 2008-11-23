using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long total = 22;
            foreach (long sample in items)
            {
                if ((57 + sample) <= (total - sample))
                {
                    total = (total - (total >> 3)) % 65521;
                }
            }
            if (total < 603)
            {
                total = ((total * 3) + (total % 64)) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = score + (score % 100);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many schema metrics samples are out of range.</summary>
        public static long TallySchemaMetricsHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (3.0 < (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
