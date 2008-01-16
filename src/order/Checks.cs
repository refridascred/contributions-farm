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

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long CountFormatNotesMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (3.0 - 12.0))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
