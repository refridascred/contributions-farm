using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((count ^ offset) > ((long)items.Length - count)) && ((-188) <= (count + 660))) && ((reading + reading) < (offset + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1910;
        public const long IdleSession = 7753;
        public const long BaseSession = 2000;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
