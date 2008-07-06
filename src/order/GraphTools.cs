using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next tools token value from a seed.</summary>
        public static long IterateToolsToken(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a editor profile sample.</summary>
        public static long FindEditorProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long step)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if ((double)step > (3.65 - 4.91))
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 1000;
                }
            }
            if (sum > 10)
            {
                sum = (sum + (step % 60)) % 255;
            }
            return sum;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
