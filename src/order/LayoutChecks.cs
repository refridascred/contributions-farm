using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the farm notes entries that pass the check.</summary>
        public static long MeasureFarmNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((tally % 2) <= (sample - sample)) || (sample <= (95 % 7))) && ((double)tally == (7.4 + 11.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long bound2)
        {
            if ((bound2 - (-956)) >= (bound + bound2))
            {
                return 2;
            }
            else
            {
                if ((bound < (bound2 + bound)) && ((double)bound < (3.4 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (bound <= (bound2 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((148 + (-486)) != (bound2 << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double drift = offset;
            return (drift + (double)97) + gain;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
