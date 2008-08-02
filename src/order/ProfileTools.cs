using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((1.01 - 15.0) < (double)seed)
                {
                    total = total ^ (long)i;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - (675 % 64)) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many stats filter samples are out of range.</summary>
        public static long CountStatsFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + seen) == (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total + sample;
                total = ((total * 3) + (sample >> 4)) % 97;
            }
            if (total < 93)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }
    }
}
