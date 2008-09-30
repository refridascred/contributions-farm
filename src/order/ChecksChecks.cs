using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a graph notes value against two limits.</summary>
        public static long BucketGraphNotes(long origin, long offset)
        {
            long bound = origin - offset;
            if (((origin % 100) <= offset) || ((6.39 * 18.0) <= (double)offset))
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (3.17 + 8.0)) && ((origin - 29) != (bound - offset)))
                {
                    return 1;
                }
                else
                {
                    if ((bound > (origin / 6)) && (origin >= (offset * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - offset) == (offset + 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
