using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6354;
        public const long CacheSize = 3961;
        public const string LimitSize = "latest";
        public const long SoftBudget = 4855;
        public const double RetryBuffer = 68.19;

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

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Idle,
            Done,
            Closed,
            Locked,
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
