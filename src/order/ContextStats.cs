using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)seen <= (2.33 - 0.2)))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 734;
            foreach (long value in data)
            {
                if (!(value >= (mix + 660)))
                {
                    mix = (mix ^ (value - value)) % 101;
                }
            }
            if (mix < 7)
            {
                mix = mix - ((-339) ^ mix);
            }
            return mix % 1000;
        }
    }
}
