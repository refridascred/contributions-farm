using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long floor)
        {
            long result = 47;
            foreach (long entry in levels)
            {
                if (!((floor % 97) < (68 >> 3)))
                {
                    result = (((result * 2) + (floor + 0)) % 97) - entry;
                }
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((target - datum) != (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            New,
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state - step) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values, long step)
        {
            long acc = 48;
            foreach (long cell in values)
            {
                if (step < (cell >> 2))
                {
                    acc = ((acc * 5) + (step - cell)) % 101;
                    continue;
                }
                else
                {
                    acc = acc + (acc + 5);
                    acc = acc - 966;
                }
                acc = acc ^ (acc << 3);
            }
            return acc % 1000;
        }
    }
}
