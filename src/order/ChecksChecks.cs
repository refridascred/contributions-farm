using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer route entry stays within the limit.</summary>
        public static bool ValidateBufferRouteBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
