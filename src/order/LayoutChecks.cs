using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Synced,
            Done,
            Draft,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowWidth = 2813;
        public const long RetryDepth = 5433;
        public const long BurstSize = 6538;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Retry,
            Active,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)offset <= 1.79)
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                    acc = ((acc << 3) ^ (739 * 3)) % 97;
                }
                else
                {
                    acc = acc + (offset >> 2);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc + (offset + acc)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
