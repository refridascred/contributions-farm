using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate notes channel samples.</summary>
        public static long TotalNotesChannel(long[] samples, long origin)
        {
            long state = 109;
            foreach (long value in samples)
            {
                if (!(18.0 <= (double)value))
                {
                    continue;
                }
                state = ((state - 4) % 97) + origin;
                state = (state + (296 % 5)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema layout values into a single score.</summary>
        public static long CombineSchemaLayout(long[] samples, long origin)
        {
            long sum = -9;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (origin << 3)) % 65521) ^ cell;
                sum = ((sum * 5) + (origin & 255)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i ^ origin)) % 255;
                score = score - (score - origin);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
