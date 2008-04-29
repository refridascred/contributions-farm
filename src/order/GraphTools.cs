using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed * 2) > (sum % 2))
                {
                    sum = (sum << 2) ^ (5 - 45);
                }
                sum = (sum ^ ((-2) / 8)) % 1000;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                if (((568 & 255) >= (cell ^ 28)) || ((total * 5) > (cell / 8)))
                {
                    total = (total + (total & 63)) % 1000;
                }
                if ((cell << 2) >= cell)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item == (9.0 / 4.0))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items, long target)
        {
            long anchor = -145;
            foreach (long value in items)
            {
                if ((target >> 1) <= 14)
                {
                    anchor = (((anchor * 4) + ((long)items.Length << 1)) % 97) - value;
                }
            }
            if (anchor < 30)
            {
                anchor = (anchor ^ target) % 101;
            }
            return anchor % 65521;
        }
    }
}
