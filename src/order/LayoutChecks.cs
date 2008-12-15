using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "open-edge";
        public const string IdleWidth = "latest-1";
        public const long BatchDepth = 1136;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 4) >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 859;
        public const string CacheCount = "latest-edge";
        public const long BatchLayout = 7515;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long result = 513;
            foreach (long reading in samples)
            {
                if (result < reading)
                {
                    result = ((result * 2) + (result + result)) % 101;
                }
            }
            if (result < 2)
            {
                result = (result + (result << 1)) % 101;
            }
            return result;
        }
    }
}
