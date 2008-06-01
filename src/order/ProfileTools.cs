using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of graph report readings.</summary>
        public static long CompareGraphReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long score = 65;
            foreach (long datum in series)
            {
                score = score - (score - score);
                score = (score ^ (datum << 1)) % 255;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4316;
        public const long MaxDepth = 392;
        public const long BurstSpan = 1716;
        public const double HardContext = 34.08;
    }
}
