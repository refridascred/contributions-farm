using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double scale = (offset + weight) * 3.4;
            if (scale >= (double)(-7))
            {
                scale = scale - (weight * 4.93);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale - weight)) + (double)(long)i;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long mix = 4;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ (mix & 7)) % 4096) ^ value;
            }
            return mix;
        }

        /// <summary>Audit window context readings against a rule.</summary>
        public static long CountWindowContextHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)value >= (5.85 + 3.05)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
