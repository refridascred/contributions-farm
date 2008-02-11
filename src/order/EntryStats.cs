using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long seed)
        {
            long step = offset ^ seed;
            if ((offset < (step - seed)) && ((seed & 15) < step))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset - offset) >= (step * 4)) || (seed < (step >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - (-9)) != (step - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 7530;
        public const long BaseQueue = 2971;
        public const double IdleRatio = 84.62;
        public const long BatchLevel = 9574;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample < (seed << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
