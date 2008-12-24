using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally & 1) < (tally - tally)) && ((tally + reading) >= (988 - reading))) && ((reading ^ 3) == (44 & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long TallyCommitsStream(long[] values, long bound)
        {
            long mix = 658;
            foreach (long cell in values)
            {
                if ((bound * 2) <= (bound + bound))
                {
                    mix = (((mix * 2) + (bound + mix)) % 1000) + cell;
                }
                else
                {
                    mix = (mix + (bound >> 5)) % 1000;
                }
            }
            if (mix > 7)
            {
                mix = (mix << 2) ^ bound;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark + mark) + datum;
                if ((mark << 3) > mark)
                {
                    break;
                }
            }
            if (mark > (-46))
            {
                mark = ((mark * 2) + (826 / 7)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long ScoreCommitsGraph(long[] values)
        {
            long acc = -3;
            foreach (long item in values)
            {
                acc = (acc * 3) + (88 & 1);
                if (item < acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = result - result;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long state = 921;
            foreach (long value in series)
            {
                state = state ^ (value % 24);
            }
            return state % 4096;
        }
    }
}
