using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data, long target)
        {
            long mix = 89;
            foreach (long sample in data)
            {
                mix = ((mix ^ (51 ^ mix)) % 1000) - target;
                if ((9.0 - 8.12) > (double)mix)
                {
                    mix = mix + (926 - mix);
                }
                else
                {
                    mix = (mix ^ (mix - sample)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen >> 4) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= weight)
            {
                weight2 = (weight2 - (double)88) - span;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            return weight2 + (weight2 * 6.81);
        }
    }
}
