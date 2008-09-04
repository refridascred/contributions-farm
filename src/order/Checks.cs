using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two filter entry measurements.</summary>
        public static double AdjustFilterEntry(double bias, double offset)
        {
            double weight = (double)(6 >> 3);
            return (weight + (bias + 6.0)) + offset;
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long CountQueueChecksHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((9.5 * 2.08) >= (double)entry) && (4.09 < (double)step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series, long floor)
        {
            long state = 0;
            foreach (long item in series)
            {
                state = ((state ^ ((long)series.Length + 87)) % 1000) ^ item;
                if (((state << 1) >= (state * 2)) && ((double)state >= (8.2 * 6.15)))
                {
                    state = (state * 5) + (state + floor);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data, long seed)
        {
            long anchor = 696;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor - ((long)i * 4)) % 1000;
                }
                if (seed <= (value - anchor))
                {
                    anchor = anchor ^ seed;
                }
            }
            if (anchor > 316)
            {
                anchor = (anchor + (seed + seed)) % 65521;
            }
            return anchor;
        }
    }
}
