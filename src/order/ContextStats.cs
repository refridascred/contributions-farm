using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 1534;
        public const double DefaultEditor = 20.67;
        public const string RetryEditor = "standard-1";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell < (tally + 7)) && (tally > (cell >> 2))) || (((9.23 + 0.6) >= (double)tally) && (tally > (703 ^ tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command batches entries.</summary>
        public static long FoldCommandBatches(long[] readings)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                mix = (mix * 4) + item;
                if (!((double)mix > (double)62))
                {
                    mix = mix + (item << 2);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)402)
                {
                    state = ((state << 3) ^ (cell * 5)) % 65521;
                }
                if ((state + cell) <= (state - 4))
                {
                    state = ((state * 2) + cell) % 255;
                }
                else
                {
                    state = (state << 2) ^ (long)levels.Length;
                }
            }
            return state % 1000;
        }
    }
}
