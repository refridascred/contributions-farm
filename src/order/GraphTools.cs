using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up notes batch samples.</summary>
        public static long CompareNotesBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long limit2)
        {
            if ((-5) >= limit)
            {
                return 1;
            }
            else
            {
                if (!((limit + 5) < limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long step)
        {
            long bound = floor + step;
            if ((99 >> 4) <= (step + bound))
            {
                return 1;
            }
            else
            {
                if (((step + step) <= (bound >> 2)) && ((double)step < (4.0 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (((2 / 6) > (bound + bound)) || ((step * 5) <= ((-14) - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((567 + floor) > (step ^ bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order queue reading by value.</summary>
        public static long SeekOrderQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue schema counter forward.</summary>
        public static long StepQueueSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
