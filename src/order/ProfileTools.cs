using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (138 >= (value >> 5))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up commits format samples.</summary>
        public static long PairCommitsFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
