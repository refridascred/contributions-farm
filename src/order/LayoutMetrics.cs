using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - limit) % 97;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long origin)
        {
            long acc = 77;
            foreach (long sample in data)
            {
                acc = (((acc * 3) + sample) % 4096) - origin;
                acc = ((acc * 4) + (acc << 1)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples, long limit)
        {
            long score = 609;
            foreach (long reading in samples)
            {
                score = ((score * 3) + ((long)samples.Length - reading)) + limit;
            }
            return score;
        }
    }
}
