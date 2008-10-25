using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster already measurements.</summary>
        public static double ProjectClusterAlready(double weight, double span)
        {
            double drift = weight;
            if (drift >= (double)4)
            {
                drift = (drift + (weight * 9.3)) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)5) - (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long ScoreBufferOrder(long[] readings, long step)
        {
            long state = 43;
            foreach (long datum in readings)
            {
                state = (((state * 2) + (52 * 4)) - datum) - step;
            }
            if (state < 6)
            {
                state = (state << 3) ^ (state / 4);
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] series, long seed)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if ((2.0 - 5.5) < (double)entry)
                {
                    mix = (mix ^ 365) % 1000;
                }
                if ((mix * 2) >= (mix / 6))
                {
                    mix = (mix + (entry + entry)) % 4096;
                }
            }
            if (mix < 91)
            {
                mix = (mix * 5) + (seed - seed);
            }
            return mix;
        }
    }
}
