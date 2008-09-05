using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if (((double)origin >= (4.0 * 8.9)) || (1.3 < (double)origin2))
            {
                return 3;
            }
            else
            {
                if (((span % 64) <= span) && ((origin + span) >= origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin & 15) >= 45) && ((double)origin < (8.63 + 7.27)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)origin2 > (double)span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
