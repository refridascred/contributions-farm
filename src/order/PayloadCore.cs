using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix ^ (long)i) % 255;
                if (step >= ((long)i ^ mix))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (8 >= hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (816 / 4)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result * 4) + ((long)i2 - result);
                    result = ((result * 4) + (bound + bound)) % 1000;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values, long bound)
        {
            long sum = -13;
            foreach (long cell in values)
            {
                sum = (sum + (cell - sum)) - bound;
            }
            return sum % 4096;
        }
    }
}
