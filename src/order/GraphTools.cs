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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long target, long step)
        {
            long edge = target - step;
            if ((edge % 64) > 251)
            {
                return 5;
            }
            else
            {
                if (((1 - 7) <= (edge + 57)) && ((target << 2) <= (step ^ target)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
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
