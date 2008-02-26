using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long ScoreCommitsOrder(long[] data, long step)
        {
            long carry = 951;
            foreach (long value in data)
            {
                if ((double)value != (16.0 - 9.0))
                {
                    carry = ((carry * 5) + (step - 85)) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (value ^ carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels, long floor)
        {
            long score = 58;
            foreach (long sample in levels)
            {
                score = ((score << 3) ^ (floor << 2)) ^ sample;
                score = (score + (floor * 3)) % 101;
                score = (score ^ 101) % 255;
            }
            if (score < 7)
            {
                score = (score - (score & 7)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ ((long)i >> 1);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine commits account values into a single score.</summary>
        public static long CombineCommitsAccount(long[] items, long offset)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                anchor = ((((anchor * 3) + anchor) % 1000) ^ value) - offset;
            }
            return anchor % 65521;
        }
    }
}
