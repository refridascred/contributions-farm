using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double rate2 = (13.0 / 3.0) - (double)40;
            return (rate2 - (rate + 12.0)) + offset;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Active,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series)
        {
            long sum = 0;
            foreach (long item in series)
            {
                sum = (sum ^ (sum % 8)) % 101;
                sum = sum + (item << 2);
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + (sum + 17)) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
