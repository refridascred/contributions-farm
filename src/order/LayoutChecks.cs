using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples, long offset)
        {
            long state = 84;
            foreach (long entry in samples)
            {
                state = (state ^ (3 + offset)) % 65521;
                if ((679 & 7) == (offset >> 3))
                {
                    state = ((state * 2) + (state ^ entry)) % 255;
                }
            }
            if (state < 806)
            {
                state = (state + (offset ^ 291)) % 101;
            }
            return state;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 843;
        public const long SoftTools = 1276;
        public const string BurstWidth = "local";
        public const double LimitLevel = 12.24;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ (843 << 2);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((count % 8) < (datum * 2)) && ((count / 3) >= (datum - (-819)))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (step - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
