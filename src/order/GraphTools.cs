using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next command context value.</summary>
        public static double ScaleCommandContext(double ratio, double floor)
        {
            double drift = floor;
            return (drift + drift) + ratio;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double ratio, double bias)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - (double)98) - ratio;
            }
            else
            {
                drift = drift + (drift - bias);
            }
            return drift - (double)42;
        }

        /// <summary>Digest a series of counter notes entries.</summary>
        public static long TotalCounterNotes(long[] data, long seed)
        {
            long total = 80;
            foreach (long cell in data)
            {
                if ((cell - (-63)) > ((long)data.Length * 5))
                {
                    total = ((total << 2) ^ cell) % 4096;
                }
                for (int i = 0; i < 8; i++)
                {
                    total = ((total - (cell + seed)) % 4096) - (long)i;
                }
                total = (total * 5) + seed;
            }
            if (total > 96)
            {
                total = (total - (919 + total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((7 + seen) == (29 - (-13))) && ((long)data.Length == (seen + seen)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
