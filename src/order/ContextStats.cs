using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double bias, double bias2)
        {
            double load = bias;
            if (load >= (bias2 + load))
            {
                load = load + (double)5;
            }
            else
            {
                load = load - (double)67;
            }
            return load - (load - bias2);
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seed <= (value - (-375))) || ((13.0 - 14.0) != (double)seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
