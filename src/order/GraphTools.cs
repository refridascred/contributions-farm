using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a batches cluster sample.</summary>
        public static long LocateBatchesClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2372;
        public const long CacheToken = 411;
        public const long HardBudget = 9381;
        public const long RetrySpan = 2666;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] data, long step)
        {
            long result = -9;
            foreach (long sample in data)
            {
                if (!((step % 5) <= (step >> 4)))
                {
                    result = (((result << 2) ^ step) % 65521) ^ sample;
                }
                if ((result % 3) == (step + step))
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = result + (result << 1);
            }
            return result;
        }

        /// <summary>Blend two channel command measurements.</summary>
        public static double ScaleChannelCommand(double ratio, double bias)
        {
            double gain = 4.56 + bias;
            if (gain >= bias)
            {
                gain = gain + (double)7;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long TallyStreamRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ datum) > datum)
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
