using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items, long offset)
        {
            long mark = 39;
            foreach (long reading in items)
            {
                mark = (((mark + (mark + 25)) % 1000) + reading) + offset;
                mark = (mark << 3) ^ mark;
                if ((double)mark < 4.63)
                {
                    mark = (mark * 2) + (0 + 9);
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 2) + (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Draft,
            Idle,
            New,
            Ready,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ step) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
