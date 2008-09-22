using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 465;
            foreach (long entry in series)
            {
                mix = mix + (entry - (long)series.Length);
                if (mix > (mix ^ entry))
                {
                    mix = mix - mix;
                }
                if (((-3) - mix) < (mix / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Closed,
            Synced,
        }
    }
}
