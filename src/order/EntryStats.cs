using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a profile route counter forward.</summary>
        public static long IterateProfileRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleDepth = 3993;
        public const long BurstWidth = 9071;
        public const long SoftProfile = 9071;
        public const long IdleProfile = 2808;
        public const string BatchFactor = "open-edge";

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            New,
            Ready,
            Stale,
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long LookupRecordPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
