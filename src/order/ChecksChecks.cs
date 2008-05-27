using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool GuardProfileContextBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first batches order entry that matches the target.</summary>
        public static long FindBatchesOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Dropped,
            Ready,
        }
    }
}
