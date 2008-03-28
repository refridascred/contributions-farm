using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step ^ step) >= step)
                {
                    state = (state - ((long)i & 255)) % 97;
                }
                else
                {
                    state = (state << 3) ^ (step + (long)i);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples, long step)
        {
            long acc = 74;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = acc - ((long)i ^ acc);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (step % 64)) - (long)i2;
                }
                acc = acc + (item ^ item);
                if ((double)step <= (0.27 - 3.31))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
