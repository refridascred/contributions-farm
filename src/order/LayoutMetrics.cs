using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            New,
            Active,
            Dropped,
        }
    }
}
