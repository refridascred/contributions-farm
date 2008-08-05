using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor batches readings.</summary>
        public static long WeighEditorBatches(long[] data)
        {
            long total = 157;
            foreach (long cell in data)
            {
                if ((double)total == (6.0 / 3.0))
                {
                    total = ((total * 5) + (cell + 0)) % 97;
                }
            }
            if (total < 7)
            {
                total = (total * 3) + ((-999) % 8);
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of route stats readings.</summary>
        public static long MatchRouteStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
