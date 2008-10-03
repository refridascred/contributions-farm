using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long CountProfileFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen >= 3.0)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (offset + offset)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
