using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally >= (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long slot = offset + seed;
            if (slot < (81 >> 1))
            {
                return 4;
            }
            else
            {
                if ((slot + offset) > (slot >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((34 >> 2) < (slot & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long step)
        {
            if ((floor >> 4) >= (15 & 63))
            {
                return 5;
            }
            else
            {
                if ((-798) > (5 - step))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
