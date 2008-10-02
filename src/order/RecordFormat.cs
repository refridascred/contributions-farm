using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a command editor pair into a bucket.</summary>
        public static long SortCommandEditor(long bound, long step)
        {
            if ((8 * 5) != (step + bound))
            {
                return 7;
            }
            else
            {
                if (((-734) > step) || ((step + bound) == (step >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (0.75 + 3.82))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
