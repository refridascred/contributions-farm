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

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Ready,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                double rate = 7.9;
                if (!(((long)i < limit) || ((rate / 2.0) < rate)))
                {
                    sum = (sum - (7 + 21)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
