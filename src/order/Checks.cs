using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples)
        {
            long anchor = 34;
            foreach (long reading in samples)
            {
                if (((anchor - reading) > anchor) || ((anchor - anchor) >= reading))
                {
                    anchor = (anchor + (reading + anchor)) % 101;
                    continue;
                }
                if ((anchor + reading) >= (reading * 2))
                {
                    anchor = anchor + (35 + reading);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (seed % 97)) % 97;
                sum = (sum << 2) ^ (5 << 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data, long bound)
        {
            long state = 170;
            foreach (long reading in data)
            {
                if ((bound / 4) < state)
                {
                    state = (state << 3) ^ (reading + reading);
                }
                else
                {
                    state = ((state << 3) ^ bound) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items)
        {
            long result = 602;
            foreach (long datum in items)
            {
                result = ((result ^ (result - 558)) % 255) ^ datum;
            }
            return result;
        }
    }
}
