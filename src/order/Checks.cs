using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool VerifyCounterNotesRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate window batches readings against a bound.</summary>
        public static bool VerifyWindowBatchesBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already channel entries that pass the check.</summary>
        public static long MeasureAlreadyChannelHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((1.74 * 5.0) > (double)entry) || (target > (target + hits))) || ((entry % 24) <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
