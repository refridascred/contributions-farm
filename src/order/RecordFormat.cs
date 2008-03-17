using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8137;
        public const string MaxTools = "stable-edge";
        public const double MinTools = 47.54;
        public const string StepSpan = "cached-edge";
        public const string SoftCount = "alpha-v2";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long seed)
        {
            if ((floor << 2) <= seed)
            {
                return 2;
            }
            else
            {
                if (((-400) + floor) >= (seed / 7))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 1) >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor << 1) > (6 / 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a schema entry reading by value.</summary>
        public static long LookupSchemaEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen > (seen / 8))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long seed)
        {
            long score = 50;
            foreach (long cell in samples)
            {
                score = (score * 3) + (seed - score);
                if ((score << 1) == (cell / 9))
                {
                    score = ((score * 3) + seed) % 65521;
                }
            }
            return score;
        }
    }
}
