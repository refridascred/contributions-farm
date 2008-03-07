using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a account profile reading by value.</summary>
        public static long LookupAccountProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next format cluster value from a seed.</summary>
        public static long StepFormatCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + acc;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the queue batch entries that pass the check.</summary>
        public static long AuditQueueBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum / 7) >= ((-72) - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
