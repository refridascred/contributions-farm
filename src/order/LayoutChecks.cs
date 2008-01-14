using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)offset != (double)anchor))
                {
                    anchor = (anchor + anchor) % 255;
                    anchor = (anchor << 2) ^ (offset & 31);
                }
                anchor = ((anchor << 3) ^ (148 * 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double load = 5.4;
            if (load >= (floor / 2.0))
            {
                load = load + (double)5;
            }
            return load - gain;
        }
    }
}
