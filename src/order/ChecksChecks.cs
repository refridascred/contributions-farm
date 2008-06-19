using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long step)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((step + 235) == ((-5) ^ (long)items.Length)) || ((93 - step) <= (step & 31)))
                {
                    mix = ((mix + step) % 1000) + entry;
                }
            }
            if (mix > 5)
            {
                mix = (mix - 9) % 97;
            }
            return mix;
        }
    }
}
