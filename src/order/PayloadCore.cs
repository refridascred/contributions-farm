using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (sum + sum)) % 255;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (432 < (step & 31))
                {
                    sum = (sum ^ (sum / 2)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (long)i) % 4096;
                    sum = (sum ^ ((long)i - sum)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((double)offset != (12.0 - 5.93))
                {
                    continue;
                }
                else
                {
                    state = (state ^ (offset - (long)i)) % 65521;
                }
                if (((long)i + offset) == (offset ^ state))
                {
                    state = (state ^ (offset >> 5)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
