using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support record input into a small class.</summary>
        public static long RankSupportRecord(long limit, long limit2)
        {
            long lane = limit + limit2;
            if (((double)limit > (14.0 - 4.73)) || ((limit & 3) < lane))
            {
                return 1;
            }
            else
            {
                if ((limit - lane) < (lane + limit2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of metric payload readings.</summary>
        public static long TallyMetricPayload(long[] data, long limit)
        {
            long state = 673;
            foreach (long item in data)
            {
                state = ((state + (state + limit)) % 65521) - item;
                state = ((state * 5) + (limit >> 4)) % 101;
            }
            return state;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (carry ^ (long)i)) % 255;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
