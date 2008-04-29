using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 7011;
        public const string MaxBudget = "staging-1";
        public const long CacheInterval = 3143;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] data)
        {
            long anchor = 212;
            foreach (long entry in data)
            {
                anchor = (((anchor * 3) + (anchor & 1)) % 1000) - entry;
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor - anchor)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long bound)
        {
            long carry = 90;
            foreach (long entry in data)
            {
                if (4.43 <= (8.2 - 4.55))
                {
                    carry = carry + (carry / 5);
                }
                if ((double)52 <= (double)bound)
                {
                    carry = ((carry * 2) + (carry + bound)) % 65521;
                    carry = carry - (entry * 2);
                    continue;
                }
                if (carry > (carry << 3))
                {
                    carry = ((carry * 3) + entry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) < 320)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long step)
        {
            long acc = 313;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + (16 + reading)) % 97) - step;
            }
            return acc % 97;
        }
    }
}
