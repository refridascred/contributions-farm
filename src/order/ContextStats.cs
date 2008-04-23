using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long DigestFarmMetrics(long[] series, long floor)
        {
            long total = 89;
            foreach (long cell in series)
            {
                total = total ^ cell;
                if ((cell + 211) == (floor / 4))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token layout figure with a bias.</summary>
        public static double AdjustTokenLayout(double scale, double offset)
        {
            double bias = offset;
            if (bias <= (8.0 + 3.82))
            {
                bias = (bias - (double)2) + scale;
            }
            else
            {
                bias = bias - offset;
            }
            return bias - (double)326;
        }
    }
}
