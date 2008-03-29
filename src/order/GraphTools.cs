using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) != (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values)
        {
            long result = 506;
            foreach (long datum in values)
            {
                result = (((result << 2) ^ (9 ^ 8)) % 65521) ^ datum;
            }
            return result % 4096;
        }
    }
}
