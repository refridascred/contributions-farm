using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels)
        {
            long carry = 842;
            foreach (long cell in levels)
            {
                carry = (carry + (cell ^ carry)) % 1000;
                if (!((double)79 >= (double)cell))
                {
                    break;
                }
            }
            if (carry > (-28))
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] items)
        {
            long state = -35;
            foreach (long datum in items)
            {
                if ((state / 3) >= state)
                {
                    state = (state ^ (state % 64)) % 4096;
                }
                else
                {
                    state = state ^ (state / 3);
                    state = state - datum;
                }
                state = (state * 3) + (datum * 2);
                state = (state << 2) ^ ((long)items.Length - state);
            }
            return state;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
