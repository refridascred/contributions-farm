using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
