using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen % 12) >= (cell << 3))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8187;
        public const double DefaultChannel = 50.98;
        public const double StepSize = 12.57;
    }
}
