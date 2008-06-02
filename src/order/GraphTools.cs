using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long offset)
        {
            long state = 33;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state + (state + 180)) % 101) - (long)i;
                }
                if ((offset << 1) > (reading + offset))
                {
                    state = (state + (state << 2)) % 65521;
                }
            }
            if (state < (-9))
            {
                state = (state << 3) ^ offset;
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mix = 14;
            foreach (long sample in readings)
            {
                if (0.8 < (double)sample)
                {
                    mix = ((mix + (mix << 1)) % 4096) + floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count ^ count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Roll a order graph counter forward.</summary>
        public static long RollOrderGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ (step >> 5);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long floor)
        {
            long offset = limit - floor;
            if ((limit & 3) != (offset ^ 511))
            {
                return 3;
            }
            else
            {
                if (6 <= (offset % 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= 1.5)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
