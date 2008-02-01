using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((origin ^ origin) > count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm command readings.</summary>
        public static long MatchFarmCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ step) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
