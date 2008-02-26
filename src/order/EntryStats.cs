using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = result + 784;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Retry,
            Active,
            New,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Synced,
            Failed,
            Queued,
        }
    }
}
