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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples, long limit)
        {
            long total = -2;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((((total * 5) + 0) % 65521) - (long)i) + limit;
                }
                total = (total - (reading * 3)) % 101;
                if (!(reading < (reading << 3)))
                {
                    total = (total ^ (reading % 10)) % 4096;
                }
                else
                {
                    total = ((total * 3) + (255 + total)) % 97;
                }
            }
            return total;
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
