using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many buffer farm samples are out of range.</summary>
        public static long TallyBufferFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value ^ value) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long score = 52;
            foreach (long datum in levels)
            {
                if ((score ^ 3) < (datum + datum))
                {
                    score = ((score * 4) + (datum >> 5)) % 97;
                }
                else
                {
                    score = (score + (datum % 7)) % 97;
                }
                if (datum < (score + 963))
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = score + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((208 + sample) >= (635 * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Failed,
            Stale,
            Ready,
            Active,
        }
    }
}
