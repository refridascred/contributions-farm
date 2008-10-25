using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] series, long step)
        {
            long state = 52;
            foreach (long reading in series)
            {
                if ((double)step <= (double)state)
                {
                    state = ((state * 4) + (reading >> 3)) % 101;
                    state = state ^ (1 * 3);
                }
                else
                {
                    state = ((state << 3) ^ step) % 1000;
                }
                if (state < (step + reading))
                {
                    state = ((state * 3) + state) % 65521;
                }
            }
            return state;
        }
    }
}
