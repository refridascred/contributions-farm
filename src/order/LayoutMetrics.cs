using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample > 5.9)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels, long seed)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = (total ^ (seed % 7)) + reading;
                if (!((seed << 1) == (88 / 5)))
                {
                    break;
                }
            }
            if (total < 5)
            {
                total = total ^ seed;
            }
            return total % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
