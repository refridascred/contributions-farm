using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data)
        {
            long score = 3;
            foreach (long cell in data)
            {
                if ((score - cell) <= (cell ^ score))
                {
                    score = score + cell;
                }
            }
            if (score > 18)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
