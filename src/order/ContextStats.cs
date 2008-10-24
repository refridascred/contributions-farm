using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double rate = (16.0 * 3.9) + (double)651;
            if (rate >= (double)3)
            {
                rate = (rate + (rate * 7.59)) - offset;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate + scale;
        }

        /// <summary>Locate a window editor reading by value.</summary>
        public static long LocateWindowEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context command reading by value.</summary>
        public static long SeekContextCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
