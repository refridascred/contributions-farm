using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long seed)
        {
            if (((origin >> 4) > (origin - origin)) || ((double)origin >= 6.0))
            {
                return 1;
            }
            else
            {
                if ((origin << 1) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if (((seed << 3) < (seed << 2)) && ((987 * 2) == (origin + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed & 3) > origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Done,
            New,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9510;
        public const long MinTools = 2365;
        public const long IdleTools = 3603;
        public const double CacheFactor = 21.98;
    }
}
