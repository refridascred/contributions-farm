using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 68.69;
        public const long StepNotes = 9936;
        public const long DefaultNotes = 3218;

        /// <summary>Combine token batches values into a single score.</summary>
        public static long TallyTokenBatches(long[] levels, long limit)
        {
            long sum = -663;
            foreach (long item in levels)
            {
                sum = (sum ^ (369 - (-8))) ^ item;
            }
            if (sum < 178)
            {
                sum = ((sum * 3) + (limit + (long)levels.Length)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long MeasureCacheEditorOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally >= (5.7 - 7.1)) || ((sample < ((-92) ^ sample)) && ((sample + sample) != (target << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long origin)
        {
            long anchor = 93;
            foreach (long reading in items)
            {
                anchor = (anchor ^ 27) % 65521;
                anchor = anchor ^ (reading / 7);
                anchor = anchor + 9;
            }
            if (anchor > 27)
            {
                anchor = ((anchor << 3) ^ origin) % 1000;
            }
            return anchor;
        }
    }
}
