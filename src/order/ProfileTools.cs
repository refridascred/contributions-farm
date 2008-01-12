using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every editor counter entry stays within the limit.</summary>
        public static bool CheckEditorCounterRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
