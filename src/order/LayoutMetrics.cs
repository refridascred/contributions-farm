using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load - rate)) - (double)(long)i;
            }
            return load + (offset + offset);
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long PairBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double gain, double floor)
        {
            double drift = gain;
            if (drift > (gain - gain))
            {
                drift = drift - (double)2;
            }
            else
            {
                drift = drift - (drift * 14.0);
            }
            return drift + floor;
        }
    }
}
