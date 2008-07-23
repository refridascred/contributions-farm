using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((-63) > ((-9) + origin)) || ((origin % 10) == ((long)samples.Length * 3))) || ((datum % 5) > datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
