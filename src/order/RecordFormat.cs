using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values, long target)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if (!((target + 244) > reading))
                {
                    score = (score * 3) + (score + reading);
                }
            }
            if (score < 2)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 3) ^ (total + (-1))) % 97;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long target)
        {
            if (!(11 > (seed - 593)))
            {
                return 1;
            }
            else
            {
                if (((seed % 3) > target) || ((target + 840) != (target & 3)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed > (double)431))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series)
        {
            long state = -658;
            foreach (long datum in series)
            {
                if ((state / 5) < 6)
                {
                    state = ((state * 5) + (state << 1)) % 65521;
                    state = state - (datum << 3);
                }
                state = (state - (datum % 60)) % 255;
                if ((double)state < (double)datum)
                {
                    state = state - (state << 3);
                }
                else
                {
                    state = state ^ (state << 1);
                }
            }
            if (state < 645)
            {
                state = ((state * 4) + (state + 8)) % 101;
            }
            return state;
        }
    }
}
