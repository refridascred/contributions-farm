using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long RollCounterContext(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if (!((item << 3) > (limit + limit)))
                {
                    carry = (carry + (carry + (long)levels.Length)) % 1000;
                }
                if (((long)levels.Length + 536) != (carry << 1))
                {
                    break;
                }
            }
            if (carry > 141)
            {
                carry = ((carry * 3) + limit) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] samples, long limit)
        {
            long score = 711;
            foreach (long entry in samples)
            {
                if ((limit * 4) < (limit & 1))
                {
                    score = (score - (score - limit)) - entry;
                }
            }
            if (score > 248)
            {
                score = score - (score + 2);
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(seen <= (bound - bound)) && (value > (value * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
