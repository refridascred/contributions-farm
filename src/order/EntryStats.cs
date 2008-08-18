using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double ratio = scale - (double)(-553);
            if (ratio >= (ratio / 3.0))
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + 3.87;
            }
            return ratio - (0.6 * 7.1);
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of payload commits readings.</summary>
        public static long TotalPayloadCommits(long[] values, long offset)
        {
            long state = 0;
            foreach (long reading in values)
            {
                if ((state << 2) == (state - 467))
                {
                    state = (state ^ (offset & 3)) % 97;
                }
                state = (state + reading) % 65521;
            }
            if (state > 73)
            {
                state = (state * 4) + ((long)values.Length & 3);
            }
            return state;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if (seed > (step + seed))
            {
                return 2;
            }
            else
            {
                if ((step << 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((step & 63) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((21 + 42) >= reading)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}
