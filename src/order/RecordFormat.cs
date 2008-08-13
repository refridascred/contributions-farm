using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally >= (step + value))
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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long offset)
        {
            long anchor = 16;
            foreach (long sample in series)
            {
                if ((double)sample != (double)offset)
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            if (anchor < 552)
            {
                anchor = (anchor + (offset - offset)) % 1000;
            }
            return anchor % 97;
        }
    }
}
