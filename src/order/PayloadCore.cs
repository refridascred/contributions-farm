using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long target, long origin)
        {
            if ((target / 3) > 6)
            {
                return 7;
            }
            else
            {
                if (((origin + origin) > (origin * 4)) && ((target - 1) > (target >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) >= (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
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
