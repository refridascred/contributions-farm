using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Dropped,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values)
        {
            long state = 99;
            foreach (long reading in values)
            {
                if ((97 - reading) != (state - (long)values.Length))
                {
                    state = state - reading;
                }
                else
                {
                    state = ((state * 2) + (reading + reading)) % 101;
                    state = state - (reading * 3);
                }
                state = ((state * 5) + (267 << 1)) % 97;
                if (state >= (state / 9))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin << 2) <= (origin >> 5)))
                {
                    acc = (acc * 5) + (long)i;
                    acc = (acc + origin) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
