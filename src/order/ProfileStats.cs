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

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long step)
        {
            long mix = 616;
            foreach (long entry in readings)
            {
                if ((step - step) == (mix % 10))
                {
                    mix = ((mix << 2) ^ 76) + entry;
                }
                else
                {
                    mix = mix ^ (404 - mix);
                }
            }
            if (mix > 808)
            {
                mix = ((mix * 4) + (step << 3)) % 4096;
            }
            return mix % 4096;
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
