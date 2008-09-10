using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate checks layout samples.</summary>
        public static long WeighChecksLayout(long[] levels)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if (!((reading >> 2) > reading))
                {
                    anchor = (anchor + (reading + reading)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
                }
                if ((anchor % 2) != (232 - reading))
                {
                    anchor = (anchor + reading) % 255;
                }
            }
            return anchor;
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

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
