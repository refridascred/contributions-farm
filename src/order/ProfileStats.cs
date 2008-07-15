using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count already metric pairs that satisfy a relation.</summary>
        public static long CompareAlreadyMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 3) + seed) % 4096) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Locked,
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of report filter readings.</summary>
        public static long DigestReportFilter(long[] values)
        {
            long mix = 94;
            foreach (long value in values)
            {
                if (((value - mix) < value) && ((mix & 31) <= mix))
                {
                    mix = (mix + (mix % 10)) % 65521;
                }
                if (20.0 < (double)value)
                {
                    mix = mix - (981 * 5);
                }
            }
            return mix;
        }
    }
}
