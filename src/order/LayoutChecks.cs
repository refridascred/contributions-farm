using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double load = 10.0 / 8.0;
            return (load - (rate * 20.0)) + floor;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen * 2) == (reading - 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
