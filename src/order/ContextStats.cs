using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate notes channel samples.</summary>
        public static long TotalNotesChannel(long[] samples, long origin)
        {
            long state = 109;
            foreach (long value in samples)
            {
                if (!(18.0 <= (double)value))
                {
                    continue;
                }
                state = ((state - 4) % 97) + origin;
                state = (state + (296 % 5)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long StepBatchesProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - (sum + 63)) % 1000;
                if (7.6 > (double)sum)
                {
                    sum = sum - (6 * 5);
                    sum = (sum << 2) ^ (977 + (long)i);
                }
                else
                {
                    sum = sum ^ sum;
                }
                sum = ((sum << 2) ^ (sum % 16)) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine schema layout values into a single score.</summary>
        public static long CombineSchemaLayout(long[] samples, long origin)
        {
            long sum = -9;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (origin << 3)) % 65521) ^ cell;
                sum = ((sum * 5) + (origin & 255)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i ^ origin)) % 255;
                score = score - (score - origin);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
