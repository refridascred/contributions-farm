using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of payload stats readings.</summary>
        public static long DigestPayloadStats(long[] values, long bound)
        {
            long state = 70;
            foreach (long value in values)
            {
                if (((-539) ^ state) == (state ^ bound))
                {
                    long prev = (state / 9) & 31;
                    state = (state - (prev - (long)values.Length)) % 255;
                }
                if ((state >> 5) == (state + bound))
                {
                    state = (state - (value >> 1)) % 101;
                }
            }
            return state;
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
