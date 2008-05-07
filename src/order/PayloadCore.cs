using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account order entry that matches the target.</summary>
        public static long SeekAccountOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((bound / 6) == (seen & 15))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi context readings against a rule.</summary>
        public static long CountContributiContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((61 + tally) <= tally)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
