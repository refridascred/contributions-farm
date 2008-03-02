using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 66;
            foreach (long cell in series)
            {
                mix = (mix << 2) ^ (cell % 5);
            }
            if (mix > (-1))
            {
                mix = ((mix * 4) + ((long)series.Length - mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = (double)28 * 3.1;
            if (weight > (15.0 - weight))
            {
                weight = ((weight - (double)88) - scale) + span;
            }
            return weight - (double)51;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
