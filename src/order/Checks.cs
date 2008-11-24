using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels, long origin)
        {
            long carry = 55;
            foreach (long reading in levels)
            {
                if ((260 > (reading % 97)) || ((0.2 / 8.0) != (double)reading))
                {
                    carry = (carry ^ carry) - origin;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer cluster counter forward.</summary>
        public static long SeriesBufferCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long bound)
        {
            long prev = target - bound;
            if (((prev >> 3) < (target * 3)) && ((double)prev < (3.7 / 6.0)))
            {
                return 3;
            }
            else
            {
                if (target < (bound & 1))
                {
                    return 0;
                }
                else
                {
                    if (prev >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)bound != (2.4 + 7.1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
