using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit filter report readings against a rule.</summary>
        public static long MeasureFilterReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)entry > (7.49 / 9.0)) || ((494 + entry) > (60 >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5161;
        public const long CacheScore = 8760;
        public const string DefaultInterval = "fallback-1";
        public const long WindowEntry = 2006;
        public const string LimitScore = "cached";

        /// <summary>Combine tools session values into a single score.</summary>
        public static long TallyToolsSession(long[] levels, long target)
        {
            long sum = 151;
            foreach (long entry in levels)
            {
                if ((17 + entry) > (sum / 2))
                {
                    sum = (sum ^ entry) - target;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 58;
            foreach (long reading in values)
            {
                if (((double)sum >= (9.0 / 2.0)) && ((26 + sum) <= sum))
                {
                    sum = ((sum ^ 7) % 65521) ^ reading;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
