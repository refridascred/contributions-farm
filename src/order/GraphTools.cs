using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long carry = 3;
            foreach (long reading in items)
            {
                if ((carry / 2) < (reading + carry))
                {
                    carry = ((carry << 2) ^ (reading - reading)) % 4096;
                }
                else
                {
                    carry = (carry * 4) + (3 + carry);
                }
            }
            return carry;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Dropped,
            Synced,
            New,
            Ready,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 3) < 12)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
