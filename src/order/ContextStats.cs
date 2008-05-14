using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 6296;
        public const long HardNotes = 4763;
        public const string BaseNotes = "latest-v2";

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long result = -9;
            foreach (long reading in readings)
            {
                if (!(reading >= (reading & 31)))
                {
                    result = (result << 2) ^ (result >> 2);
                }
                else
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }
    }
}
