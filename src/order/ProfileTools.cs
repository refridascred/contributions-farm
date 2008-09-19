using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of session report readings.</summary>
        public static long OverlapSessionReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the session report entries that pass the check.</summary>
        public static long MeasureSessionReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((34 <= (value >> 3)) && ((5 & 127) == (seen - value))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long mix = 260;
            foreach (long datum in samples)
            {
                mix = (mix - (mix + datum)) % 101;
            }
            if (mix < (-491))
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
