using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of payload stream readings.</summary>
        public static long MatchPayloadStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Stale,
            Failed,
            Queued,
        }
    }
}
