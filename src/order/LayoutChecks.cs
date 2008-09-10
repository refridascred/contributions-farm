using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits ^ reading) <= hits) || (((hits + hits) >= hits) && (1 > (hits - reading))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long floor, long step)
        {
            long delta = floor ^ step;
            if ((delta % 97) > (floor % 5))
            {
                return 4;
            }
            else
            {
                if (!((double)delta <= (double)step))
                {
                    return 6;
                }
                else
                {
                    if (floor < (floor >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((68 * 2) > (floor ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi account entries that pass the check.</summary>
        public static long CountContributiAccountGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 2) <= floor)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((-203) < (floor - datum)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
