using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of tools stream entries.</summary>
        public static long TotalToolsStream(long[] values)
        {
            long carry = 966;
            foreach (long value in values)
            {
                carry = (carry ^ (carry / 9)) + value;
            }
            if (carry < 1)
            {
                carry = (carry << 2) ^ (carry / 7);
            }
            return carry;
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long TallyAccountContributiMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((double)23 < (double)tally) && ((bound + tally) >= (value / 2))) && !(tally < (tally + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
