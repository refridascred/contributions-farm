using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((((60 ^ count) > (long)data.Length) && ((double)cell == (8.9 / 9.0))) || ((cell >> 2) >= (583 - 788)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Active,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long acc = 786;
            foreach (long value in readings)
            {
                acc = ((acc * 3) + 61) + value;
            }
            if (acc > 245)
            {
                acc = acc + acc;
            }
            return acc % 97;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step << 2) >= step)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
