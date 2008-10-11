using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long BucketToolsSchema(long target, long offset)
        {
            if (offset >= (offset + 748))
            {
                return 1;
            }
            else
            {
                if (offset >= target)
                {
                    return 8;
                }
                else
                {
                    if ((4.63 - 9.0) == (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
