using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((bound + reading) >= (bound + 169))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxTimeout = 5;
        public const double StepStream = 8.41;
        public const double BaseStream = 16.21;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long seed)
        {
            long result = 42;
            foreach (long reading in values)
            {
                if ((115 + reading) != (result % 7))
                {
                    result = (result + ((long)values.Length + 492)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (seed & 63);
                }
                if ((6.52 / 9.0) != (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
