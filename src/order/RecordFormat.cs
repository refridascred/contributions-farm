using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor tools value against two limits.</summary>
        public static long BucketEditorTools(long seed, long floor)
        {
            if (((double)seed != (double)floor) || ((floor + seed) > (70 - 27)))
            {
                return 1;
            }
            else
            {
                if ((floor * 5) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Done,
            Draft,
            New,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long offset, long floor)
        {
            long step = offset ^ floor;
            if (871 <= (offset - offset))
            {
                return 6;
            }
            else
            {
                if ((3.28 / 4.0) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + step) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
