using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Locked,
            New,
            Stale,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data)
        {
            long mix = -19;
            foreach (long sample in data)
            {
                mix = (mix * 3) + (sample + mix);
                if ((mix & 31) < (sample - sample))
                {
                    mix = (mix + (mix + sample)) % 65521;
                }
                else
                {
                    mix = (mix ^ 576) % 65521;
                }
            }
            if (mix > 4)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long offset)
        {
            if (((offset ^ offset) <= limit) || (38 < (offset * 5)))
            {
                return 2;
            }
            else
            {
                if (((double)offset < (5.2 * 8.0)) && ((double)offset <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
