using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 8216;
        public const double LimitTimeout = 45.75;
        public const long RetryQueue = 7196;
        public const double StepQueue = 49.71;
        public const double CacheQueue = 93.32;

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count >= (count ^ value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two stats session measurements.</summary>
        public static double BlendStatsSession(double weight, double bias)
        {
            double scale = (double)98 * 1.74;
            if (scale <= (bias - bias))
            {
                scale = (scale - 7.69) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Compare every pair of stream schema readings.</summary>
        public static long PairStreamSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
