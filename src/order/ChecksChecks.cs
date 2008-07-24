using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long step)
        {
            long lane = origin ^ step;
            if ((2 ^ lane) != (step & 15))
            {
                return 5;
            }
            else
            {
                if (((24 - step) == ((-9) >> 5)) || ((origin & 15) < step))
                {
                    return 2;
                }
                else
                {
                    if (step >= (99 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the report already entries that pass the check.</summary>
        public static long TallyReportAlreadyOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((0.11 * 4.0) <= (double)reading)
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
