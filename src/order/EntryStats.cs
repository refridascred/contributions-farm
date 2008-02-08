using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support schema counter forward.</summary>
        public static long DeriveSupportSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ (target - 63)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long MatchClusterReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool CheckChecksCacheLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
