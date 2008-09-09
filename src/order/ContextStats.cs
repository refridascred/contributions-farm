using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
