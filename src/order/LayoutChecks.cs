using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double weight = gain - bias;
            if (weight <= bias)
            {
                weight = weight - (gain * 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)97) + (double)(long)i;
            }
            return weight + (double)63;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell <= (hits - cell))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] series)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                carry = (carry + (datum + datum)) % 4096;
            }
            if (carry > 86)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 4096;
        }
    }
}
