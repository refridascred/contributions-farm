using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate stats session samples.</summary>
        public static long WeighStatsSession(long[] levels, long bound)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length < 8) && ((9.59 / 5.0) == (double)mark))
                {
                    mark = ((mark - (bound - 2)) % 255) - reading;
                }
            }
            if (mark > (-7))
            {
                mark = (mark * 2) + (bound & 255);
            }
            return mark;
        }
    }
}
