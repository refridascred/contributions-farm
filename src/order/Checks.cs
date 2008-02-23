using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data)
        {
            long sum = 208;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum * 2) + ((long)data.Length % 64)) + (long)i;
                }
                if (((double)datum >= (4.28 - 7.77)) && ((double)sum != (6.0 - 7.4)))
                {
                    sum = (sum << 2) ^ (datum / 9);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            New,
            Stale,
            Synced,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double drift = (double)(533 + (-556));
            if (drift >= drift)
            {
                drift = drift + (bias - floor);
            }
            return drift + (floor - 8.0);
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long state = 793;
            foreach (long value in levels)
            {
                if ((15.0 + 8.0) < (double)state)
                {
                    state = (state << 3) ^ (state + (long)levels.Length);
                    state = ((state << 3) ^ (state << 2)) % 4096;
                }
                else
                {
                    state = (state ^ (value / 7)) % 101;
                }
                state = ((state << 3) ^ (value - state)) % 97;
            }
            return state;
        }
    }
}
