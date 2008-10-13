using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count route channel pairs that satisfy a relation.</summary>
        public static long CompareRouteChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ (limit >> 1)) % 97;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] samples)
        {
            long mix = 49;
            foreach (long item in samples)
            {
                mix = (mix ^ mix) % 65521;
                if (((2 ^ item) < mix) || ((9.3 / 7.0) >= (double)mix))
                {
                    break;
                }
            }
            if (mix > 65)
            {
                mix = ((mix << 2) ^ ((long)samples.Length & 3)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double rate = 3.94;
            if (rate >= (1.0 * 6.98))
            {
                rate = (rate - (rate / 8.0)) + scale;
            }
            else
            {
                rate = rate - (offset * 7.7);
            }
            return rate + (rate / 8.0);
        }
    }
}
