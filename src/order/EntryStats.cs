using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long floor)
        {
            long score = 1;
            foreach (long datum in readings)
            {
                score = (((score + (score / 9)) % 65521) - datum) + floor;
            }
            if (score < 773)
            {
                score = (score - (score << 1)) % 255;
            }
            return score % 97;
        }

        /// <summary>Roll a editor entry counter forward.</summary>
        public static long SeriesEditorEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result - result) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowSize = 9484;
        public const double StepDepth = 40.69;
        public const long RetryRatio = 9318;
        public const string BatchRatio = "alpha-edge";
    }
}
