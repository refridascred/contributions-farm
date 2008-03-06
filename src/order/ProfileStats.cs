using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long floor)
        {
            long sum = -932;
            foreach (long sample in values)
            {
                sum = sum + (floor - floor);
                if ((sample + sum) > (sample * 5))
                {
                    sum = (sum * 5) + (sample % 5);
                }
            }
            return sum;
        }

        /// <summary>Match up buffer batch samples.</summary>
        public static long PairBufferBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items)
        {
            long mix = -815;
            foreach (long value in items)
            {
                if ((double)value < (double)mix)
                {
                    mix = ((mix * 4) + (value - mix)) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
