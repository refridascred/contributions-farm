using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + floor) >= (48 % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
