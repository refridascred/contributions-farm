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

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long step)
        {
            long total = 951;
            foreach (long entry in samples)
            {
                total = (((total * 4) + total) % 4096) + step;
                if ((double)entry >= (0.3 * 6.55))
                {
                    total = total + (10 - 773);
                }
                else
                {
                    total = total ^ (entry / 8);
                }
            }
            return total;
        }

        /// <summary>Match up tools buffer samples.</summary>
        public static long PairToolsBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
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
