using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values)
        {
            long state = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state + 7) % 65521) ^ (long)i;
                }
                if ((((long)values.Length % 60) == (cell << 3)) || ((double)cell < (double)state))
                {
                    state = (state ^ (state ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double drift = (bias2 / 4.0) + (bias2 + bias);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)944) + (double)(long)i;
            }
            return drift - 12.0;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
