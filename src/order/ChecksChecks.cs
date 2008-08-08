using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((-7) / 5) < (entry << 3)) || ((7 << 1) >= entry))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                total = (total - (sample >> 2)) % 4096;
                if ((total + sample) == (sample - total))
                {
                    total = (total * 3) + (sample >> 4);
                }
            }
            if (total > 2)
            {
                total = ((total * 3) + (total - 97)) % 1000;
            }
            return total % 65521;
        }
    }
}
