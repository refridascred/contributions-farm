using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long anchor = 45;
            foreach (long datum in items)
            {
                anchor = ((anchor * 5) + (target + 552)) % 4096;
                if (!((target ^ anchor) >= anchor))
                {
                    anchor = (anchor - (anchor ^ datum)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Paused,
            Locked,
            New,
            Idle,
        }
    }
}
