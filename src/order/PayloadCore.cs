using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes editor entries that pass the check.</summary>
        public static long CountNotesEditorGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits & 7) <= hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitLevel = 2010;
        public const string SoftWidth = "fallback-1";
        public const long BaseQueue = 3238;

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (span - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)55) + (double)(long)i;
            }
            return weight - 8.9;
        }
    }
}
