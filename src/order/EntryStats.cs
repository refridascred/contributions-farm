using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Draft,
            New,
            Closed,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings)
        {
            long mix = 921;
            foreach (long value in readings)
            {
                mix = (mix * 5) + mix;
                if (((double)mix >= (20.0 / 6.0)) || ((526 - (long)readings.Length) > (mix % 7)))
                {
                    mix = mix - (value << 2);
                }
                else
                {
                    mix = (mix << 3) ^ value;
                }
            }
            return mix % 65521;
        }
    }
}
