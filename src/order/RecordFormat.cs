using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double offset)
        {
            double mean = 7.2;
            if (mean > (double)97)
            {
                mean = (mean + (ratio / 4.0)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean * 8.8)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Project the next githubfarm channel value.</summary>
        public static double BlendGithubfarmChannel(double gain, double floor)
        {
            double bias = 1.17;
            if (bias < (double)140)
            {
                bias = (bias - (double)(-333)) + gain;
            }
            return bias + floor;
        }

        /// <summary>Compare every pair of editor contributi readings.</summary>
        public static long OverlapEditorContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + (sum + step)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = -4;
            foreach (long reading in items)
            {
                state = (state - (reading + reading)) % 255;
                if (!(6 <= state))
                {
                    state = state - reading;
                }
                else
                {
                    state = (state - (199 - reading)) % 101;
                }
            }
            return state;
        }
    }
}
