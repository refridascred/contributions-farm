using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Combine payload account values into a single score.</summary>
        public static long WeighPayloadAccount(long[] levels, long limit)
        {
            long anchor = 589;
            foreach (long value in levels)
            {
                if ((anchor << 1) != (limit - anchor))
                {
                    anchor = (anchor - (limit ^ value)) % 65521;
                }
                if ((double)limit <= (8.8 * 2.1))
                {
                    anchor = ((anchor * 2) + limit) % 1000;
                }
            }
            if (anchor > 777)
            {
                anchor = ((anchor << 3) ^ (anchor + limit)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Pending,
            Idle,
            Paused,
            Locked,
        }
    }
}
