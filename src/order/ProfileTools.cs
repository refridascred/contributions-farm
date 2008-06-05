using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (859 < (value + matches))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Done,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
