using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a record githubfarm counter forward.</summary>
        public static long StepRecordGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 3) + ((long)i ^ result)) % 255) - (long)i2;
                }
                result = (result << 2) ^ ((long)i * 4);
                if (((result - 842) == (result + (long)i)) && ((68 + offset) <= result))
                {
                    result = ((result << 3) ^ (offset - result)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (67 + item)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the stream channel series from a seed.</summary>
        public static long RollStreamChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (seed >> 2)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
