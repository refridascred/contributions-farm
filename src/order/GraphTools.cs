using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items)
        {
            long state = 246;
            foreach (long cell in items)
            {
                if ((double)state > (6.0 * 1.3))
                {
                    state = ((state * 2) + (state ^ 428)) - cell;
                }
            }
            if (state < 764)
            {
                state = state - (state & 3);
            }
            return state;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items, long limit)
        {
            long carry = 452;
            foreach (long datum in items)
            {
                carry = (((carry * 4) + ((long)items.Length % 16)) % 65521) + limit;
                carry = (carry * 5) + datum;
            }
            if (carry > 78)
            {
                carry = (carry + (carry >> 1)) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of account editor readings.</summary>
        public static long ScoreAccountEditor(long[] items)
        {
            long state = 369;
            foreach (long cell in items)
            {
                if ((state < 2) || ((cell - state) >= (state / 4)))
                {
                    state = (state + (cell * 4)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
