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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long anchor = 48;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (159 - 8)) % 255;
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 101) ^ (long)i;
                }
                if (((8.9 / 7.0) < (double)datum) && ((target >> 1) == (3 - anchor)))
                {
                    anchor = (anchor ^ (datum / 9)) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (target - datum);
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
