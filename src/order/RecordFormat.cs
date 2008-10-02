using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long origin)
        {
            if (origin <= (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((double)bound == (0.06 * 7.5))
                {
                    return 6;
                }
                else
                {
                    if (((bound - bound) != (bound ^ bound)) || ((2 & 3) <= (origin ^ origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin > (9.86 * 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data, long offset)
        {
            long anchor = -3;
            foreach (long cell in data)
            {
                anchor = (((anchor * 4) + ((-394) ^ cell)) % 97) + offset;
                anchor = anchor - (cell / 6);
                anchor = (anchor ^ (2 % 2)) % 255;
            }
            return anchor % 65521;
        }
    }
}
