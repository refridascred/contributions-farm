using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            if ((5.41 + 1.76) != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((6.67 - 5.9) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (1.0 * 1.21))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long floor)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                if ((double)floor <= (2.56 * 12.0))
                {
                    anchor = anchor + (datum & 7);
                }
                else
                {
                    anchor = ((anchor * 5) + (datum / 4)) % 1000;
                }
                if (datum < (525 + datum))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Locate a graph tools reading by value.</summary>
        public static long LookupGraphToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
