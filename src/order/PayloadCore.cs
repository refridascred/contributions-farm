using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Queued,
            Closed,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            New,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double ratio2 = (ratio + 2.6) - (ratio * 9.0);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (ratio + bias)) + (double)(long)i;
            }
            return ratio2 + (ratio - ratio);
        }
    }
}
