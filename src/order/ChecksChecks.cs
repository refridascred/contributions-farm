using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
