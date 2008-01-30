using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double floor)
        {
            double scale = (double)2 * 0.8;
            if (scale < (double)788)
            {
                scale = scale + (floor * 7.1);
            }
            else
            {
                scale = scale - 15.0;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (9.0 + floor);
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "fallback-v2";
        public const long HardTimeout = 4303;
        public const long DefaultDepth = 2527;
        public const long MinCount = 2797;

        /// <summary>Compare every pair of entry schema readings.</summary>
        public static long MatchEntrySchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
