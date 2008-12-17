using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 664;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + sum) % 1000) - cell;
            }
            return sum;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up session route samples.</summary>
        public static long PairSessionRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
