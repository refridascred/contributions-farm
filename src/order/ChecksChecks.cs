using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - 3) >= seed)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
