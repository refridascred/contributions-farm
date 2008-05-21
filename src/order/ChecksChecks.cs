using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every cluster context entry stays within the limit.</summary>
        public static bool ValidateClusterContextLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count tools batch pairs that satisfy a relation.</summary>
        public static long PairToolsBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((state >> 2) > (long)i)
                {
                    state = ((state << 3) ^ (limit * 5)) % 255;
                    state = (state - (limit ^ limit)) % 4096;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
