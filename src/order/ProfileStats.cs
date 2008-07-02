using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                if ((target + acc) < (acc % 24))
                {
                    acc = acc + (acc + 0);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 0.67))
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (offset / 9.0);
            }
            return gain - 19.0;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (14 > (seen + limit))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
