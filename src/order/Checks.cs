using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph farm pairs that satisfy a relation.</summary>
        public static long PairGraphFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Queued,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Combine filter graph values into a single score.</summary>
        public static long TotalFilterGraph(long[] readings)
        {
            long score = 4;
            foreach (long value in readings)
            {
                if ((double)score == (8.87 + 4.0))
                {
                    score = (score + (value + 808)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
