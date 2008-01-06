using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i / 8) != (long)i)
                {
                    mark = ((mark * 4) + ((long)i + bound)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = state - (573 ^ 654);
                state = ((state << 3) ^ (state & 7)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
