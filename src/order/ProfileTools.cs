using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long offset2)
        {
            if (((double)offset2 > (14.0 + 12.0)) || ((double)offset2 != (double)4))
            {
                return 7;
            }
            else
            {
                if ((offset < offset2) || ((8 << 3) == (offset2 / 7)))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 6) != (offset ^ offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset2 < (offset2 + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a counter batches reading.</summary>
        public static double ProjectCounterBatches(double scale, double span)
        {
            double drift = 0.6 / 4.0;
            if (drift < (double)84)
            {
                drift = drift + (scale * 0.33);
            }
            return drift + span;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Stale,
            New,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long step)
        {
            long mix = 465;
            foreach (long value in readings)
            {
                mix = (((mix - mix) % 101) + value) + step;
                mix = mix + (mix + mix);
            }
            if (mix > 27)
            {
                mix = ((mix * 4) + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of metric session entries.</summary>
        public static long TotalMetricSession(long[] series)
        {
            long mark = 689;
            foreach (long datum in series)
            {
                if (mark >= datum)
                {
                    mark = (mark + (long)series.Length) % 65521;
                }
                else
                {
                    mark = mark - (datum / 6);
                }
            }
            return mark;
        }
    }
}
