using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            New,
            Ready,
            Stale,
            Idle,
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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen > (8.4 + 4.1))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
