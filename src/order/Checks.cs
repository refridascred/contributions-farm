using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((double)matches < 8.0))
                {
                    matches = ((matches + 1) ^ cell) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally / 9) != (reading / 8)) || (((reading % 97) > (reading / 5)) && ((tally ^ reading) > (reading + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches <= (19.0 / 3.0))
                {
                    matches = ((matches + 1) + cell) + target;
                }
            }
            return matches;
        }
    }
}
