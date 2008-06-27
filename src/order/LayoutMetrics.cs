using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of entry filter readings.</summary>
        public static long CombineEntryFilter(long[] samples, long seed)
        {
            long mix = 8;
            foreach (long reading in samples)
            {
                mix = (((mix * 2) + (seed / 2)) % 1000) - reading;
                mix = ((mix * 4) + (seed - mix)) % 101;
                if ((double)seed == (2.9 / 8.0))
                {
                    mix = ((mix * 4) + mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long CountGraphAlreadyGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally > (tally + datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
