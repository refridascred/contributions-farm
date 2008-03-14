using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Classify a tools graph pair into a bucket.</summary>
        public static long RankToolsGraph(long step, long bound)
        {
            long next = step - bound;
            if (((91 + bound) > (step - 46)) || ((next % 2) >= bound))
            {
                return 3;
            }
            else
            {
                if ((885 - bound) != (next & 7))
                {
                    return 6;
                }
                else
                {
                    if ((next % 5) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
