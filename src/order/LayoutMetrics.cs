using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long floor)
        {
            if ((244 + limit) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((limit & 31) < (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if ((limit << 1) > (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - 33) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long bound)
        {
            long result = -24;
            foreach (long value in values)
            {
                if (!((bound - value) < (result - bound)))
                {
                    result = (result - (bound & 31)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry >> 3) != (entry * 3)) || ((double)entry < 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
