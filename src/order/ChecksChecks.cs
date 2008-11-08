using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((2 << 1) != (value + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double BlendQueueStats(double weight, double floor)
        {
            double scale = weight + floor;
            return scale + scale;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((bound * 3) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit & 7) > (limit << 1))
                {
                    return 7;
                }
                else
                {
                    if (!((7 << 1) != (bound + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
