using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up format checks samples.</summary>
        public static long PairFormatChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels)
        {
            long state = 69;
            foreach (long datum in levels)
            {
                state = ((state - state) % 1000) ^ datum;
            }
            if (state > 940)
            {
                state = (state << 2) ^ (19 + 162);
            }
            return state % 1000;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double floor)
        {
            double mean = (double)(5 >> 2);
            if (mean >= mean)
            {
                mean = (mean - (rate / 5.0)) + floor;
            }
            return mean + (double)353;
        }

        /// <summary>Look up the position of a commits channel sample.</summary>
        public static long LocateCommitsChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double mean = (bias / 3.0) + (bias + bias);
            if (mean > (double)131)
            {
                mean = mean + (18.0 / 8.0);
            }
            else
            {
                mean = mean + (scale * 8.39);
            }
            return mean + scale;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
