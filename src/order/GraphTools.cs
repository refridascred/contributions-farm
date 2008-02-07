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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((tally + limit) <= (entry - entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report already samples.</summary>
        public static long CombineReportAlready(long[] data)
        {
            long mix = 9;
            foreach (long sample in data)
            {
                if ((mix - sample) == ((long)data.Length - sample))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = mix - (mix >> 4);
                }
            }
            return mix;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
