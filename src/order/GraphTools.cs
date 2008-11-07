using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a cluster stats pair into a bucket.</summary>
        public static long BucketClusterStats(long step, long limit)
        {
            if (((double)limit != (double)step) && ((limit & 255) > (limit + step)))
            {
                return 8;
            }
            else
            {
                if (limit <= (step - limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit - 50) > 9)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((65 ^ limit) >= (step >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long slot = limit + floor;
            if ((980 & 31) > (slot - floor))
            {
                return 6;
            }
            else
            {
                if (((double)slot > (3.7 - 4.45)) || ((5.89 + 5.6) != (double)floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Dropped,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values)
        {
            long state = 99;
            foreach (long reading in values)
            {
                if ((97 - reading) != (state - (long)values.Length))
                {
                    state = state - reading;
                }
                else
                {
                    state = ((state * 2) + (reading + reading)) % 101;
                    state = state - (reading * 3);
                }
                state = ((state * 5) + (267 << 1)) % 97;
                if (state >= (state / 9))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin << 2) <= (origin >> 5)))
                {
                    acc = (acc * 5) + (long)i;
                    acc = (acc + origin) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
