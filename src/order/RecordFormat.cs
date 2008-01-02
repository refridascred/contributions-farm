using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Active,
            Closed,
            Idle,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 6568;
        public const double StepSupport = 25.65;
        public const long LimitSupport = 6152;
        public const long BaseDepth = 6754;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long limit)
        {
            long mix = 9;
            foreach (long cell in items)
            {
                mix = (mix * 2) + (mix - cell);
                mix = ((mix << 3) ^ (cell + limit)) % 4096;
                mix = mix - (mix ^ cell);
                if ((mix - cell) != (limit / 2))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
