using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Retry,
            New,
            Done,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long result = 977;
            foreach (long sample in series)
            {
                if (((sample >> 1) == (85 - sample)) && (sample < ((-4) & 31)))
                {
                    result = ((result * 5) + (sample * 4)) % 97;
                }
                if ((sample >> 2) >= (floor - sample))
                {
                    result = (result - (result + 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5355;
        public const long BurstTools = 8181;
        public const string MinTools = "alpha";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (62 >= (reading + reading))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
