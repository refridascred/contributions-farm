using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                if ((acc > (sample / 5)) || ((acc << 3) != (177 << 3)))
                {
                    acc = (acc + (0 * 5)) % 1000;
                    acc = (acc * 5) + (acc + acc);
                }
                else
                {
                    acc = (acc + acc) % 101;
                }
                if (acc < (acc - sample))
                {
                    acc = (acc << 3) ^ sample;
                }
            }
            if (acc < 11)
            {
                acc = ((acc * 2) + (52 ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long MeasureOrderContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length >= (hits / 5)) && (hits < (value + 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
