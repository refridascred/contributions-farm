using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Paused,
            Synced,
            New,
            Closed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 627;
            foreach (long cell in series)
            {
                if ((double)cell != (9.6 + 2.01))
                {
                    result = ((result << 2) ^ (cell * 5)) % 255;
                }
            }
            if (result > 7)
            {
                result = result ^ ((long)series.Length + 8);
            }
            return result % 65521;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double floor)
        {
            double weight = (double)(62 + 8);
            if (weight >= weight)
            {
                weight = (weight + weight) + ratio;
            }
            else
            {
                weight = weight + (floor * 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (floor - floor);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Dropped,
            Retry,
            Queued,
        }
    }
}
