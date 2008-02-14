using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftFactor = 66.33;
        public const long BurstFactor = 7648;
        public const long IdleWidth = 9011;
        public const long DefaultTimeout = 5158;
        public const long BurstLayout = 6394;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((1 % 12) != (anchor & 7)) && ((4.76 - 2.3) != (double)(long)samples.Length))
                {
                    anchor = (((anchor - (anchor & 1)) % 255) - value) - origin;
                }
                else
                {
                    anchor = anchor + (anchor >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed >> 5);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a tools channel sample.</summary>
        public static long SeekToolsChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
