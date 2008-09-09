using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long AuditReportPayloadMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((72 >> 3) >= (seen % 2))
                {
                    seen = ((seen + 3) - reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Check that every profile stream entry stays within the limit.</summary>
        public static bool VerifyProfileStreamBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
