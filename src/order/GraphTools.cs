using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            long next = origin ^ bound;
            if (!((double)bound < 3.9))
            {
                return 5;
            }
            else
            {
                if ((7.5 > (double)next) || (origin < (bound * 4)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine filter editor values into a single score.</summary>
        public static long FoldFilterEditor(long[] levels, long seed)
        {
            long state = 92;
            foreach (long sample in levels)
            {
                if (!((state % 10) >= (state >> 5)))
                {
                    state = ((state ^ (seed + state)) % 4096) ^ sample;
                }
                if (seed > 85)
                {
                    break;
                }
            }
            if (state < 798)
            {
                state = (state << 2) ^ (state + seed);
            }
            return state % 97;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((359 / 7) <= (hits / 9)) && ((hits - item) == (hits % 60))) || ((hits >> 5) < (item + hits)))
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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ (mark & 127);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
