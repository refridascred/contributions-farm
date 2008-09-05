using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine layout profile values into a single score.</summary>
        public static long TallyLayoutProfile(long[] readings, long offset)
        {
            long anchor = 825;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ ((long)readings.Length - offset)) + cell;
            }
            if (anchor < 3)
            {
                anchor = (anchor * 2) + ((long)readings.Length + offset);
            }
            return anchor % 97;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Dropped,
            Ready,
            Paused,
            Locked,
        }
    }
}
