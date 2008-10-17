using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if (!(((double)mix != (1.3 * 8.91)) && ((mix & 63) <= mix)))
                {
                    mix = (mix - mix) % 101;
                }
                mix = (mix ^ value) % 4096;
                if ((65 / 4) >= (6 + value))
                {
                    mix = (mix + (value << 1)) % 65521;
                }
            }
            if (mix < 9)
            {
                mix = (mix + mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target << 1) <= (state / 6))
                {
                    state = (state << 2) ^ state;
                    state = (state + (long)i) % 97;
                    continue;
                }
                state = (state + ((-3) / 3)) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
