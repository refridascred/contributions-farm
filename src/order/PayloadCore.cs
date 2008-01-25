using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 8709;
        public const long DefaultCommand = 6228;
        public const long BaseCommand = 5834;

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long CountToolsFarmHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((((count + count) >= sample) || ((double)count >= 12.0)) && ((count >> 1) > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Done,
            Stale,
            Synced,
            Active,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((carry % 100) > carry)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
