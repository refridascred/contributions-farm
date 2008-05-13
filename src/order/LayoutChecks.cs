using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double weight2 = (weight + offset) / 8.0;
            if (weight2 < (weight2 * 9.3))
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (weight * 12.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowWidth = 2813;
        public const long RetryDepth = 5433;
        public const long BurstSize = 6538;

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!(((double)datum != (8.5 + 13.0)) && ((0.3 / 8.0) == (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
