using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state << 2) ^ (seed * 5)) % 255;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state + (state - state)) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long AuditBufferClusterHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((1.5 + 9.56) <= (double)origin) && (origin >= (79 - tally))) || ((2.0 * 19.0) < (double)origin))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a already session counter forward.</summary>
        public static long DeriveAlreadySession(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if (step > mix)
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ 5) % 101;
                }
                if (step <= 974)
                {
                    mix = mix - step;
                    mix = (mix ^ ((long)i + step)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
