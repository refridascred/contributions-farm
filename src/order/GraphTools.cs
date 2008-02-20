using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long ClassifyFarmBatch(long origin, long step)
        {
            long prev = origin - step;
            if ((double)step < 5.06)
            {
                return 6;
            }
            else
            {
                if ((prev - step) != (prev & 1))
                {
                    return 1;
                }
                else
                {
                    if ((step / 2) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin - 493) >= step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long target)
        {
            if ((step <= (step ^ step)) || ((step + step) < 660))
            {
                return 2;
            }
            else
            {
                if (7 < (step - target))
                {
                    return 6;
                }
                else
                {
                    if (((-4) - 83) > step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step >> 2) < (step * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ 9) != (cell << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long step)
        {
            long edge = limit + step;
            if ((edge > limit) || (limit > (edge & 1)))
            {
                return 3;
            }
            else
            {
                if ((step % 7) <= (edge << 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
