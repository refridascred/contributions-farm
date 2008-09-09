using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels, long step)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ step) + sample;
            }
            if (acc > 509)
            {
                acc = ((acc << 3) ^ (step - 73)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of record commits readings.</summary>
        public static long OverlapRecordCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metric stream measurements.</summary>
        public static double ProjectMetricStream(double bias, double floor)
        {
            double gain = floor;
            if (gain < (floor / 3.0))
            {
                gain = (gain + (double)4) - bias;
            }
            return gain + gain;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
