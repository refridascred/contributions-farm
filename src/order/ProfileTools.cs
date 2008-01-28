using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data, long limit)
        {
            long state = 745;
            foreach (long cell in data)
            {
                state = (state * 2) + state;
                if (limit <= (cell - state))
                {
                    state = (state + (cell / 8)) % 255;
                }
                else
                {
                    state = ((state * 5) + (775 << 3)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long DeriveOrderSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((state + (-6)) == (state - state)) && ((seed ^ state) > (seed & 63)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings)
        {
            long mix = 269;
            foreach (long value in readings)
            {
                mix = ((mix - (mix << 1)) % 4096) ^ value;
            }
            if (mix > 1)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix % 65521;
        }
    }
}
