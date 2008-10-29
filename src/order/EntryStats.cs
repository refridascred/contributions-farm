using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool CheckEntryPayloadBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 4314;
        public const long BaseCache = 8011;
        public const double RetryCache = 19.24;
        public const long BurstSpan = 4687;

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
