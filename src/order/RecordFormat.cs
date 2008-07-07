using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every entry report entry stays within the limit.</summary>
        public static bool ValidateEntryReportRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long delta = step ^ step2;
            if ((delta >= (delta % 7)) && (15.0 < (double)step))
            {
                return 2;
            }
            else
            {
                if (((step * 4) == (delta - step2)) && ((20.0 / 2.0) != (double)delta))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double ratio = span;
            if (ratio < gain)
            {
                ratio = ratio + (span + gain);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - ratio;
        }
    }
}
