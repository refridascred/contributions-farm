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

        /// <summary>Rank already notes input into a small class.</summary>
        public static long SortAlreadyNotes(long step, long origin)
        {
            long delta = step + origin;
            if (!(step <= (3 ^ step)))
            {
                return 1;
            }
            else
            {
                if ((delta ^ origin) >= (origin * 5))
                {
                    return 8;
                }
                else
                {
                    if ((5.0 * 3.07) > (double)delta)
                    {
                        return 6;
                    }
                    else
                    {
                        if (step <= (414 - 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
