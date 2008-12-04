using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + tally) >= value) && ((value - 15) >= (579 - tally))) && (((double)tally != (double)value) && ((double)tally <= 6.41)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (seed + (long)i)) % 97;
                state = ((state << 3) ^ (long)i) % 1000;
                if ((seed + 361) < (seed % 97))
                {
                    state = ((state << 2) ^ (state & 1)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (8 + 47)) % 97;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long bound)
        {
            long gap = offset + bound;
            if ((gap ^ offset) != (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if (((gap ^ offset) != (offset - 8)) && ((offset - gap) <= 682))
                {
                    return 8;
                }
                else
                {
                    if ((double)57 == (double)gap)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double ratio = 4.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + gain;
            }
            return ratio - (floor - 6.3);
        }
    }
}
