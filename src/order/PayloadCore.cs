using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine tools record values into a single score.</summary>
        public static long TallyToolsRecord(long[] data, long seed)
        {
            long state = 768;
            foreach (long reading in data)
            {
                state = ((state * 4) + (state * 2)) % 97;
                if (((double)73 < (0.01 / 2.0)) || ((seed & 7) < (reading + state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] items)
        {
            long acc = 97;
            foreach (long item in items)
            {
                acc = (acc ^ (acc % 64)) % 65521;
                acc = ((acc << 3) ^ (item - acc)) % 65521;
                acc = acc ^ item;
            }
            return acc % 97;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double drift = offset;
            return (drift + offset) + scale;
        }
    }
}
