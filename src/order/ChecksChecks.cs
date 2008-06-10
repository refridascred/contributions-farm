using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next stream report value from a seed.</summary>
        public static long IterateStreamReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(((total % 12) >= (offset + total)) && ((offset * 3) == (533 / 2))))
                {
                    total = (total - (offset ^ total)) % 65521;
                }
                total = (total + ((-880) % 64)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Dropped,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Grade a batches schema value against two limits.</summary>
        public static long GradeBatchesSchema(long step, long origin)
        {
            long step2 = step + origin;
            if (((5.15 - 2.1) >= (double)step) && ((origin - 4) == (step2 & 3)))
            {
                return 5;
            }
            else
            {
                if (step2 > (step2 % 8))
                {
                    return 3;
                }
                else
                {
                    if ((step2 * 4) != (step2 & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (origin % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
