using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((limit >> 3) <= (limit * 3))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((-9) + tally) <= (49 - cell)))
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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
