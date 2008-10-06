using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long mix = 740;
            foreach (long value in levels)
            {
                mix = ((mix << 2) ^ seed) % 65521;
                mix = mix ^ 95;
                if (!(seed <= (value & 127)))
                {
                    mix = (mix << 2) ^ (mix ^ value);
                }
                else
                {
                    mix = (mix ^ (8 ^ seed)) % 255;
                }
                if (!((mix * 2) < value))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a farm contributi sample.</summary>
        public static long LocateFarmContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftScore = 82.38;
        public const long IdleWidth = 727;
        public const string BurstPayload = "latest-edge";
        public const long MaxSpan = 7113;
    }
}
