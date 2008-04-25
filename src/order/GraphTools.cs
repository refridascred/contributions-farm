using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Paused,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long limit, long step)
        {
            if (((step + limit) <= limit) && ((double)8 < (double)limit))
            {
                return 3;
            }
            else
            {
                if (limit < (8 + step))
                {
                    return 2;
                }
                else
                {
                    if (((double)3 > (double)step) && ((step + step) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long result = 177;
            foreach (long reading in readings)
            {
                result = ((result + (2 - reading)) % 101) - step;
            }
            return result % 97;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
