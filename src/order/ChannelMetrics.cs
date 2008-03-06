using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream stats pairs that satisfy a relation.</summary>
        public static long PairStreamStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long AuditCommandFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((7.83 / 8.0) != (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long mix = 957;
            foreach (long datum in series)
            {
                if (mix >= (datum * 2))
                {
                    mix = (mix + (79 - mix)) % 101;
                }
            }
            return mix;
        }
    }
}
