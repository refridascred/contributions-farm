using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            long lane = floor + bound;
            if ((double)bound >= 2.6)
            {
                return 4;
            }
            else
            {
                if ((double)lane == (7.2 * 5.0))
                {
                    return 2;
                }
                else
                {
                    if (((bound % 60) == (lane % 64)) && ((floor + lane) >= (floor ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + bound) == (bound + 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (floor + 621))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
