using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((bound + 790) >= (count + bound)) && (count >= reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data, long limit)
        {
            long result = 161;
            foreach (long datum in data)
            {
                if (!(2.0 < (double)datum))
                {
                    result = (result - (limit - datum)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 2) ^ (long)i;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state + state) % 97) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >> 3) != (count + value))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Blend two window channel measurements.</summary>
        public static double BlendWindowChannel(double rate, double bias)
        {
            double bias2 = (rate + rate) / 9.0;
            if (bias2 > (double)3)
            {
                bias2 = (bias2 + (bias2 + rate)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
