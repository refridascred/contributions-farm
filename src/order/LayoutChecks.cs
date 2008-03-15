using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double offset)
        {
            double ratio = (double)(-613) + offset;
            if (ratio >= (offset - bias))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (ratio + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "local";
        public const long MinRatio = 543;
        public const long BurstSpan = 380;
        public const long LimitAlready = 8972;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long origin)
        {
            long state = 967;
            foreach (long item in values)
            {
                state = ((state << 2) ^ ((long)values.Length + item)) + origin;
            }
            if (state > 51)
            {
                state = (state - state) % 1000;
            }
            return state % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long origin)
        {
            long carry = 94;
            foreach (long value in values)
            {
                if ((value + 2) > carry)
                {
                    carry = (carry ^ (origin & 127)) % 65521;
                }
                if ((value & 7) < (value + origin))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the editor notes series from a seed.</summary>
        public static long StepEditorNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - (target >> 1);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Dropped,
            Queued,
            Done,
        }
    }
}
