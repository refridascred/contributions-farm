using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - 2) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long TallyEntrySchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - 5) < (4 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter filter series from a seed.</summary>
        public static long StepCounterFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = acc ^ (acc * 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset + floor) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if (floor < (floor & 31))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
