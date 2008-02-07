using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 7607;
        public const long RetryInterval = 8504;
        public const long BaseTools = 5813;
        public const long WindowScore = 6779;
        public const double WindowDepth = 25.23;

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
