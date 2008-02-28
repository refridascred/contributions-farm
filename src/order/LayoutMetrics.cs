using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate order graph readings against a bound.</summary>
        public static bool CheckOrderGraphRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values)
        {
            long acc = -540;
            foreach (long sample in values)
            {
                if (!((acc - acc) == (sample & 7)))
                {
                    acc = acc - (acc + 64);
                }
                else
                {
                    acc = ((acc * 5) + (acc + sample)) % 255;
                }
            }
            return acc;
        }
    }
}
