using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Idle,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((1.92 / 4.0) == (double)tally) || ((sample - tally) < (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values, long bound)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                if (!((bound >> 4) == (datum % 2)))
                {
                    acc = acc + (datum ^ (-192));
                }
                else
                {
                    acc = ((acc << 2) ^ (datum / 7)) % 4096;
                }
                if ((acc >> 4) <= (datum >> 2))
                {
                    break;
                }
            }
            if (acc > (-8))
            {
                acc = (acc * 4) + (acc % 10);
            }
            return acc;
        }
    }
}
