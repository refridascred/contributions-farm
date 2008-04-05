using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
