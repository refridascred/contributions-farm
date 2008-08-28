using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Accumulate editor entry samples.</summary>
        public static long CombineEditorEntry(long[] data, long seed)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if ((9.9 + 3.0) > (double)datum)
                {
                    result = (result ^ (seed % 97)) % 4096;
                }
            }
            if (result > (-431))
            {
                result = (result ^ (4 * 2)) % 4096;
            }
            return result % 1000;
        }
    }
}
