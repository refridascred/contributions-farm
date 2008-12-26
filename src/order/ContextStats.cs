using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long mix = -9;
            foreach (long item in samples)
            {
                if (item >= (item - floor))
                {
                    mix = mix + (item + 77);
                    mix = ((mix * 3) + (mix + item)) % 4096;
                }
                if (((floor << 2) >= mix) || ((floor ^ mix) == (mix + floor)))
                {
                    mix = (mix + floor) % 97;
                }
                else
                {
                    mix = (mix + (floor - item)) % 97;
                }
            }
            if (mix > 2)
            {
                mix = mix ^ (floor * 5);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long origin)
        {
            long state = 170;
            foreach (long entry in series)
            {
                if ((state + state) >= state)
                {
                    state = (state ^ (entry + state)) - origin;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - 5) >= (floor + floor))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
