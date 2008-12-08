using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 3.97;
        public const long MinWidth = 7279;
        public const long MaxRatio = 64;

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long bound)
        {
            long total = 797;
            foreach (long reading in data)
            {
                if (!((reading * 3) == (total + 276)))
                {
                    total = total - reading;
                }
            }
            if (total > 84)
            {
                total = (total - (bound ^ 790)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
