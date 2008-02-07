using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data, long seed)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                if ((double)datum > (double)seed)
                {
                    anchor = ((anchor * 3) + seed) % 101;
                }
            }
            if (anchor < 21)
            {
                anchor = anchor + ((long)data.Length * 3);
            }
            return anchor;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            long diff = step ^ bound;
            if ((209 + 2) > (diff + step))
            {
                return 4;
            }
            else
            {
                if ((step ^ step) >= (bound + 314))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
