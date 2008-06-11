using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long bound)
        {
            long bound2 = limit + bound;
            if ((bound2 & 7) != (bound + bound2))
            {
                return 6;
            }
            else
            {
                if ((limit - 59) < (bound2 & 3))
                {
                    return 3;
                }
                else
                {
                    if (bound2 >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound2 >= (7.0 / 5.0)) || (limit > (bound2 * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
