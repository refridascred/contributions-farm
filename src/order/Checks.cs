using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 12) < (216 % 97))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double load = scale;
            if (load <= bias)
            {
                load = load + 8.76;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double load = rate * 8.0;
            if (load < (6.82 + 1.63))
            {
                load = (load - (3.0 * 9.71)) - offset;
            }
            return load - (load - 13.0);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
