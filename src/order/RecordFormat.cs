using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value + target) == (target - 238)) || (((tally + value) <= tally) && ((value % 24) == (tally + target))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
