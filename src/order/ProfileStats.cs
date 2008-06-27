using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((datum >= (datum / 6)) || ((3.1 - 19.0) >= (double)datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Draft,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Locate a farm payload reading by value.</summary>
        public static long LocateFarmPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
