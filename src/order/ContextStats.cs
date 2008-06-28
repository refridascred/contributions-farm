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

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long seed)
        {
            long sum = 52;
            foreach (long sample in readings)
            {
                if ((double)seed <= (double)(long)readings.Length)
                {
                    sum = ((sum << 3) ^ seed) - sample;
                }
                else
                {
                    sum = (sum ^ (seed & 7)) % 1000;
                }
            }
            return sum;
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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((1.0 / 9.0) <= (double)sample)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
