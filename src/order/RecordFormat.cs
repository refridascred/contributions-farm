using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stream schema values into a single score.</summary>
        public static long FoldStreamSchema(long[] data)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = (total + datum) % 65521;
            }
            if (total < 722)
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 1713;
        public const string BaseBudget = "staging-1";
        public const string BatchBudget = "legacy-edge";
        public const long BatchInterval = 7252;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long target)
        {
            if (target < (7 - target))
            {
                return 5;
            }
            else
            {
                if (!((origin * 4) > (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
