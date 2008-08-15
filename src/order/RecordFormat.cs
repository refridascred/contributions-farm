using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long limit)
        {
            long score = 79;
            foreach (long value in levels)
            {
                score = ((score + (score / 8)) + value) + limit;
            }
            return score;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + ((long)i + (long)i)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum - (sum / 9)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long bound, long step)
        {
            if (bound > (step - step))
            {
                return 6;
            }
            else
            {
                if ((double)step <= 1.5)
                {
                    return 8;
                }
                else
                {
                    if ((step + 69) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound >> 1) < 4) && ((double)step >= (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
