using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels, long target)
        {
            long result = 3;
            foreach (long entry in levels)
            {
                if (!(84 >= entry))
                {
                    result = ((result * 2) + (result >> 4)) - target;
                }
                else
                {
                    result = ((result * 3) + (entry * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc * 4) + (offset - acc);
                acc = ((acc * 2) + (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate command session readings against a bound.</summary>
        public static bool CheckCommandSessionBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Synced,
            New,
            Draft,
            Active,
        }
    }
}
